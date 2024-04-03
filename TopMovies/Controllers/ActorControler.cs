using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Web.Controllers
{
	public class ActorControler : BaseController
	{
		private readonly IActorService actorService;

		public ActorControler(IActorService actorService)
		{
			this.actorService = actorService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			var actorExists = await actorService.ExistsByIdAsync(id);

			ActorDetailsViewModel actor;

			if (!actorExists)
			{
				return Redirect(Request.Headers["Referer"].ToString());
			}

			try
			{
				actor = await actorService.GetAllMovieActorsByMovieIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return Redirect(Request.Headers["Referer"].ToString());

			}

			return View(actor);
		}
	}
