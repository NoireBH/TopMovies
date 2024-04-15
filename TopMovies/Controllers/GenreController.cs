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

			bool genreExists = await genreService.ExistsByName(model.Name);

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

        public async Task<IActionResult> AddToMovie()
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
        public async Task<IActionResult> AddToMovie(GenreAddOrEditFormModel model)
        {
            bool isAdmin = User.IsAdmin();

            if (!isAdmin)
            {
                TempData[ErrorMessage] = "You need to be an admin to add a genre!";
                return View(model);
            }

            bool genreExists = await genreService.ExistsByName(model.Name);

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
    }
}
