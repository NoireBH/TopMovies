using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;

namespace TopMovies.Web.Controllers
{
    public class MovieController : Controller
    {
        private IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var movieExists = await movieService.ExistsByIdAsync(id);

            if (!movieExists)
            {
                return NotFound();
            }

            return View();
        }
    }
}
