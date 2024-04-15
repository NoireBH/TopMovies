using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.MovieCharacters;

namespace TopMovies.Web.Controllers
{
	public class MovieCharacterController : BaseController
	{
		private readonly IMovieCharacterService movieCharacterService;

		public MovieCharacterController(IMovieCharacterService actorService)
		{
			this.movieCharacterService = actorService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			var movieCharacterExists = await movieCharacterService.ExistsByIdAsync(id);

			MovieCharacterDetailsViewModel movieCharacter;

			if (!movieCharacterExists)
			{
				return Redirect(Request.Headers["Referer"].ToString());
			}

			try
			{
				movieCharacter = await movieCharacterService.GetMovieCharacterByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return Redirect(Request.Headers["Referer"].ToString());

			}

			return View(movieCharacterExists);
		}
	}
}
