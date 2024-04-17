using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Infrastructure.Extensions;
using TopMovies.Web.ViewModels.UserReviews;
using static TopMovies.Common.NotificationMessagesConstants;

namespace TopMovies.Web.Controllers
{
	public class UserReviewController : BaseController
	{
		private readonly IUserReviewService userReviewService;

		public UserReviewController(IUserReviewService userReviewService)
		{
			this.userReviewService = userReviewService;
		}

		public async Task<IActionResult> AddToMovie(string movieId, string applicationUserId)
		{

			var userHasReview = await userReviewService.UserHasReviewedMovieByUserIdAsync(applicationUserId, movieId);

			if (userHasReview)
			{
				TempData[ErrorMessage] = "You already have a review! Try editing or deleting it instead";
				return RedirectToAction("All", "UserReview");
			}

			var model = new UserReviewAddOrEditFormModel()
			{
				MovieId = movieId,
				ApplicationUserId = applicationUserId,			
			};

			return View(model);

		}

		[HttpPost]
		public async Task<IActionResult> AddToMovie(UserReviewAddOrEditFormModel model)
		{

			var userHasReview = await userReviewService.UserHasReviewedMovieByUserIdAsync(model.ApplicationUserId, model.MovieId);

			if (userHasReview)
			{
				TempData[ErrorMessage] = "You already have a review! Try editing or deleting it instead";
				return RedirectToAction(nameof(All), new { id = model.MovieId });
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			 await userReviewService.AddReviewToMovieAsync(model);

			return RedirectToAction(nameof(All), new { id = model.MovieId });

		}

		[AllowAnonymous]
		public async Task<IActionResult> All(string id)
		{

			var reviews = await userReviewService.GetAllMovieReviewsByMovieIdAsync(id);

			return View(reviews);

		}

		public async Task<IActionResult> Edit(string movieId, string applicationUserId)
		{
			var userHasReview = await userReviewService.UserHasReviewedMovieByUserIdAsync(applicationUserId, movieId);

			if (!userHasReview)
			{
				TempData[ErrorMessage] = "You haven't reviewed this movie!";
				return RedirectToAction(nameof(All), new {id = movieId});
			}

			var review = await userReviewService.GetCurrentUserReviewByUserAndMovieIdAsync(applicationUserId, movieId);

			var reviewModel = new UserReviewAddOrEditFormModel()
			{
				ApplicationUserId = applicationUserId,
				MovieId = movieId,
				Comment = review.Comment
			};

			return View(reviewModel);

		}

		[HttpPost]
		public async Task<IActionResult> Edit(UserReviewAddOrEditFormModel model)
		{

			var userHasReview = await userReviewService.UserHasReviewedMovieByUserIdAsync(model.ApplicationUserId, model.MovieId);

			if (!userHasReview)
			{
				TempData[ErrorMessage] = "You haven't reviewed this movie!";
				return RedirectToAction(nameof(All), new { id = model.MovieId.ToString() });
			}


			if (!ModelState.IsValid)
			{
				return View(model);
			}


			try
			{
				await userReviewService.EditReviewAsync(model);
			}
			catch (Exception)
			{
				ModelState.AddModelError
					(string.Empty, "Unexpected error has occured, while trying to edit house details, please try again later...");
				return View(model);

			}

			return RedirectToAction(nameof(All), new { id = model.MovieId.ToString() });
		}

		public async Task<IActionResult> Delete(string applicationUserId, string movieId)
		{
			var userHasReview = await userReviewService.UserHasReviewedMovieByUserIdAsync(applicationUserId, movieId);

			if (!userHasReview)
			{
				TempData[ErrorMessage] = "You dont have a review to delete!";
				return RedirectToAction(nameof(All), new { id = movieId });
			}

			try
			{
				await userReviewService.DeleteByUserAndMovieIdAsync(applicationUserId, movieId);
			}
			catch (Exception)
			{
				TempData[ErrorMessage] = "Something went wrong! Please try again or contact support.";
			}

			return RedirectToAction(nameof(All), new { id = movieId });
		}

		public async Task<IActionResult> Mine()
		{
			string? userId = User.GetId();

			var reviews = await userReviewService.GetAllReviewsOfUserByIdAsync(userId!);

			return View(reviews);
		}
	}
}
