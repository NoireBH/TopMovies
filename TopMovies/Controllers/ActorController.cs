using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Infrastructure.Extensions;
using TopMovies.Web.ViewModels.Actors;
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
				TempData[ErrorMessage] = "You need to be an admin to add a actor and their role!";
				return Unauthorized();
			}

			bool actorAndRoleExist = await actorService.ExistsByActorAndMovieCharacterNames(model.ActorName, model.MovieCharacterName);

			if (actorAndRoleExist)
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
				await actorService.AddActorAndRoleToMovieAsync(model, model.MovieId);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				return View(model);

			}

			return RedirectToAction("Details", "Movie", new { id = model.MovieId });

		}

		public async Task<IActionResult> RemoveActorAndRoleFromMovie(string movieId, int actorId)
		{
			if (!User.IsAdmin())
			{
				TempData[ErrorMessage] = "You have to be an admin in order to delete a movie's actor and their role!";
				return Unauthorized();
			}

			if (!await actorService.ExistsByActorAndMovieIdAsync(actorId, movieId))
			{
				TempData[ErrorMessage] = "The actor and their role doesn't exist,please try again.";
				return RedirectToAction("Details", "Movie", new { id = movieId });
			}

			try
			{
				await actorService.DeleteActorAndRoleFromMovieByTheirIdsAsync(movieId, actorId);
			}
			catch (Exception)
			{
				TempData[ErrorMessage] = "Something went wrong! Please try again or contact support.";
			}

			return RedirectToAction("Details", "Movie", new { id = movieId });
		}

		public async Task<IActionResult> EditMovieActorAndRole(string movieId, int actorId)
		{
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You need to be an admin to add a actor and their role!";
				return Unauthorized();
			}

			bool actorAndRoleExist = await actorService.ExistsByActorAndMovieIdAsync(actorId, movieId);

			if (!actorAndRoleExist)
			{
				TempData[ErrorMessage] = "The actor and their role don't exist!";
				return NotFound();
			}

			var actorMovieCharacter = await actorService.GetActorAndTheirRoleByMovieIdAsync(movieId, actorId);

			var model = new MovieActorAndRoleAddOrEditFormModel()
			{
				ActorId = actorId,
				MovieId = movieId,
				ActorName = actorMovieCharacter.ActorName,
				ActorDescription = actorMovieCharacter.ActorDescription,
				ActorDateOfBirth = actorMovieCharacter.ActorDateOfBirth,
				ActorImageUrl = actorMovieCharacter.ActorImageUrl,
				MovieCharacterName = actorMovieCharacter.MovieCharacterName,
				MovieCharacterAge = actorMovieCharacter.MovieCharacterAge,
				MovieCharacterImageUrl = actorMovieCharacter.MovieCharacterImageUrl
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> EditMovieActorAndRole(MovieActorAndRoleAddOrEditFormModel model)
		{
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You need to be an admin to add a actor and their role!";
				return Unauthorized();
			}

			bool actorAndRoleExist = await actorService.ExistsByActorAndMovieIdAsync(model.ActorId, model.MovieId);

			if (!actorAndRoleExist)
			{
				TempData[ErrorMessage] = "The actor and they're role don't exist!";
				return BadRequest();
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			try
			{
				await actorService.EditActorAndRoleFromMovieByTheirIdsAsync(model, model.ActorId);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				return View(model);

			}

			return RedirectToAction("Details", "Movie", new { id = model.MovieId });

		}
	}
}
