using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Infrastructure.Extensions;
using TopMovies.Web.ViewModels.Actors;
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

			 await userReviewService.AddReviewToMovie(model);

			return RedirectToAction(nameof(All), new { id = model.MovieId });

		}

		[AllowAnonymous]
		public async Task<IActionResult> All(string id)
		{

			var reviews = await userReviewService.GetAllUserReviewsByMovieIdAsync(id);

			return View(reviews);

		}
	}
}
