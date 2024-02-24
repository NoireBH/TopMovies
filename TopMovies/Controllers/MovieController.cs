using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Web.Controllers
{
    public class MovieController : BaseController
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
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
    }
}
