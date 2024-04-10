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
				return Redirect(Request.Headers["Referer"].ToString());
			}

			try
			{
				 movie = await movieService.GetMovieDetailsByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return Redirect(Request.Headers["Referer"].ToString());

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
				return Redirect(Request.Headers["Referer"].ToString());
			}

			try
			{
				movie = await movieService.GetMovieDetailsByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return Redirect(Request.Headers["Referer"].ToString());

			}

			return View(movie);
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			bool isAdmin =  User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You have to be an admin in order to add a movie!";
				return BadRequest();
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
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				model.Genres = await genreService.GetAllGenresAsync();
				return View(model);

			}

			return RedirectToAction("All", "Movie");

		}
	}
}
