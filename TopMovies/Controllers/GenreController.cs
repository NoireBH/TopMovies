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
				TempData[ErrorMessage] = "You have to be an admin in order to add a movie!";
				return Redirect(HttpContext.Request.Headers["Referer"]);
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(GenreAddOrEditFormModel model)
		{

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
	}
}
