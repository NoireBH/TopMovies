using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Infrastructure.Extensions;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.Genres;
using static TopMovies.Common.NotificationMessagesConstants;

namespace TopMovies.Web.Controllers
{
	public class ActorController : BaseController
	{
		private readonly IActorService actorService;

		public ActorController(IActorService actorService)
		{
			this.actorService = actorService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			var actorExists = await actorService.ExistsByIdAsync(id);

			ActorDetailsViewModel actor;

			if (!actorExists)
			{
				return NotFound();
			}

			try
			{
				actor = await actorService.GetActorByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return StatusCode(500);

			}

			return View(actor);
		}

		public async Task<IActionResult> AddActorAndRoleToMovie(string id)
		{
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You need to be an admin to add a actor and their role!";
				return Unauthorized();
			}

			var model = new MovieActorAndRoleAddOrEditFormModel()
			{
				MovieId = id
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> AddActorAndRoleToMovie(MovieActorAndRoleAddOrEditFormModel model)
		{
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You need to be an admin to add a genre!";
				return Unauthorized();
			}

			bool actorExists = await actorService.ExistsByActorAndMovieCharacterNames(model.ActorName, model.MovieCharacterName);

			if (actorExists)
			{
				TempData[ErrorMessage] = "The actor and they're role already exist!";
				return BadRequest();
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			try
			{
				await actorService.AddActorAndRoleToMovie(model, model.MovieId);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				return View(model);

			}

			return RedirectToAction("Details", "Movie", new { id = model.MovieId });

		}

		//public async Task<IActionResult> RemoveFromMovie(int genreId, string movieId)
		//{
		//	if (!User.IsAdmin())
		//	{
		//		TempData[ErrorMessage] = "You have to be an admin in order to delete a movie genre!";
		//		return Redirect(HttpContext.Request.Headers["Referer"]);
		//	}

		//	if (!await genreService.ExistsByGenreIdAndMovieIdAsync(genreId, movieId))
		//	{
		//		TempData[ErrorMessage] = "The movie doesn't have the genre you're trying to delete,please try again.";
		//		return RedirectToAction("Details", "Movie", new { id = movieId });
		//	}

		//	try
		//	{
		//		await genreService.DeleteGenreFromMovieByGenreAndMovieIdAsync(genreId, movieId);
		//	}
		//	catch (Exception)
		//	{
		//		TempData[ErrorMessage] = "Something went wrong! Please try again or contact support.";
		//	}

		//	return RedirectToAction("Details", "Movie", new { id = movieId });
		//}
	}
}
