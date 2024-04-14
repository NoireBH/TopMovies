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

		public async Task<IActionResult> Add()
		{			
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You have to be an admin in order to add a movie!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			return View();


		}

		[HttpPost]
		public async Task<IActionResult> Add(MovieAddOrEditFormModel model)
		{
			bool movieExists = await movieService
				.ExistsByNameAndReleaseDate
				(model.Name, model.ReleaseDate.Year, model.ReleaseDate.Month, model.ReleaseDate.Day);

			if (movieExists)
			{
				TempData[ErrorMessage] = "The movie you're trying to add already exists!";
				return View(model);
			}

			if (!ModelState.IsValid)
			{
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


		public async Task<IActionResult> Edit(string id)
		{
			if (!User.IsAdmin())
			{
				TempData[ErrorMessage] = "You have to be an admin in order to delete a movie!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			if (!await movieService.ExistsByIdAsync(id))
			{
				return BadRequest();
			}

			var movie = await movieService.GetMovieDetailsByIdAsync(id);

			var houseModel = new MovieAddOrEditFormModel()
			{
				Id = movie.Id,
				Name = movie.Name,
				Description = movie.Description,
				ImageUrl = movie.ImageUrl,
				ReleaseDate = movie.ReleaseDate,
				TrailerUrl = movie.TrailerUrl

			};

			return View(houseModel);

		}

		[HttpPost]
		public async Task<IActionResult> Edit(MovieAddOrEditFormModel model)
		{			

			if (!User.IsAdmin())
			{
				TempData[ErrorMessage] = "You must be an agent and the owner of this house to be able to edit!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}


			if (!ModelState.IsValid)
			{
				return View(model);
			}


			try
			{
				await movieService.EditMovie(model);
			}
			catch (Exception)
			{
				ModelState.AddModelError
					(string.Empty, "Unexpected error has occured, while trying to edit house details, please try again later...");
				return View(model);

			}

			return RedirectToAction(nameof(Details), new { id = model.Id });
		}
	}
}