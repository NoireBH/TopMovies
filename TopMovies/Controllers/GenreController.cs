using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Infrastructure.Extensions;
using TopMovies.Web.ViewModels.Genres;
using TopMovies.Web.ViewModels.Movies;
using static TopMovies.Common.NotificationMessagesConstants;

namespace TopMovies.Web.Controllers
{
	public class GenreController : BaseController
	{
		private readonly IGenreService genreService;

		public GenreController(
			IGenreService genreService)
		{
			this.genreService = genreService;
		}

		public async Task<IActionResult> Add()
		{
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You need to be an admin to add a genre!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(GenreAddOrEditFormModel model)
		{
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You need to be an admin to add a genre!";
				return View(model);
			}

			bool genreExists = await genreService.ExistsByNameAsync(model.Name);

			if (genreExists)
			{
				TempData[ErrorMessage] = "The genre already exists!";
				return View(model);
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			try
			{
				await genreService.AddGenreAsync(model);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				return View(model);

			}

			return RedirectToAction("All", "Movie");

		}

        public async Task<IActionResult> AddToMovie(string id)
        {
            bool isAdmin = User.IsAdmin();

            if (!isAdmin)
            {
                TempData[ErrorMessage] = "You need to be an admin to add a genre!";
				return Unauthorized();
            }

			var movieGenreModel = new MovieGenreAddOrEditFormModel
			{
				MovieId = id,
				Genres = await genreService.GetAllGenresAsync()
			};

			return View(movieGenreModel);
		}

        [HttpPost]
        public async Task<IActionResult> AddToMovie(MovieGenreAddOrEditFormModel model)
        {
            bool isAdmin = User.IsAdmin();

            if (!isAdmin)
            {
                TempData[ErrorMessage] = "You need to be an admin to add a genre!";
				return Unauthorized();
			}

            bool genreExists = await genreService.ExistsByIdAsync(model.GenreId);

            if (!genreExists)
            {
				model.Genres = await genreService.GetAllGenresAsync();
				TempData[ErrorMessage] = "The genre you're trying to add doesn't exists!";
				return BadRequest();
            }

            if (!ModelState.IsValid)
            {
				model.Genres = await genreService.GetAllGenresAsync();

				return View(model);
            }

            try
            {
                await genreService.AddGenreToMovieAsync(model, model.MovieId);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
                return View(model);

            }

            return RedirectToAction("All", "Movie");

        }
    }
}
