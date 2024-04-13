using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Infrastructure.Extensions;
using TopMovies.Web.ViewModels.Movies;
using static TopMovies.Common.NotificationMessagesConstants;

namespace TopMovies.Web.Controllers
{
	public class MovieController : BaseController
	{
		private readonly IMovieService movieService;
		private readonly IGenreService genreService;

		public MovieController(
			IMovieService movieService,
			IGenreService genreService)
		{
			this.movieService = movieService;
			this.genreService = genreService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> Details(string id)
		{
			var movieExists = await movieService.ExistsByIdAsync(id);

			MovieDetailsViewModel movie;

			if (!movieExists)
			{
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			try
			{
				movie = await movieService.GetMovieDetailsByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return Redirect(HttpContext.Request.Headers["Referer"]);

			}

			return View(movie);
		}

		[HttpGet]
		public async Task<IActionResult> Rate(string id)
		{
			var movieExists = await movieService.ExistsByIdAsync(id);

			MovieDetailsViewModel movie;

			if (!movieExists)
			{
				TempData[ErrorMessage] = "The movie you're trying to rate doesn't exist!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			try
			{
				movie = await movieService.GetMovieDetailsByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return Redirect(HttpContext.Request.Headers["Referer"]);

			}

			return View(movie);
		}

		[AllowAnonymous]
		public async Task<IActionResult> All()
		{
			var movies = await movieService.GetAllMoviesAsync();

			return View(movies);

		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You have to be an admin in order to add a movie!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			return View(new MovieAddOrEditFormModel
			{
				Genres = await genreService.GetAllGenresAsync()
			});


		}

		[HttpPost]
		public async Task<IActionResult> Add(MovieAddOrEditFormModel model)
		{

			if (!ModelState.IsValid)
			{
				model.Genres = await genreService.GetAllGenresAsync();

				return View(model);
			}

			try
			{
				await movieService.AddMovieAsync(model);
				ModelState.FirstOrDefault(x => x.Key == nameof(model.TrailerUrl)).Value!.RawValue = model.TrailerUrl.Replace("watch?v=", "embed/");
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				model.Genres = await genreService.GetAllGenresAsync();
				return View(model);

			}

			return RedirectToAction("All", "Movie");

		}

		public async Task<IActionResult> Delete(string id)
		{
			if (!User.IsAdmin())
			{
				TempData[ErrorMessage] = "You have to be an admin in order to delete a movie!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			try
			{
				if (!await movieService.ExistsByIdAsync(id))
				{
					TempData[ErrorMessage] = "A movie with that id does not exist!";
					return Redirect(HttpContext.Request.Headers["Referer"]);
				}

				await movieService.DeleteAsync(id);
			}
			catch (Exception)
			{
				TempData[ErrorMessage] = "Something went wrong! Please try again or contact support.";
			}

			return RedirectToAction(nameof(All));
		}
	}
}