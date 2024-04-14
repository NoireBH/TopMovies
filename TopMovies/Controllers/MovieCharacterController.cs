using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.Actors;

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
			var actorExists = await 

			ActorDetailsViewModel actor;

			if (!actorExists)
			{
				return Redirect(Request.Headers["Referer"].ToString());
			}

			try
			{
				actor = await movieCharacterService.GetActorByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return Redirect(Request.Headers["Referer"].ToString());

			}

			return View(actor);
		}
	}
}
