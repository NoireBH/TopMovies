using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using TopMovies.Services.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Controllers;
using TopMovies.Web.ViewModels;
using TopMovies.Web.ViewModels.Home;

namespace TopMovies.Controllers
{
    public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> logger;
		private readonly IMovieService movieService;

		public HomeController(
			ILogger<HomeController> logger,
			IMovieService movieService
			)
		{
			this.logger = logger;
			this.movieService = movieService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
		{
            FeaturedMoviesViewModel[] featuredMovies = await movieService.GetFeaturedMoviesAsync();

            return View(featuredMovies);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}