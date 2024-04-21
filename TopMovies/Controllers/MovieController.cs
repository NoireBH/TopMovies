using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.Infrastructure.Extensions;
using TopMovies.Web.ViewModels.Movies;
using TopMovies.Web.ViewModels.Page;
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

		[AllowAnonymous]
		public async Task<IActionResult> Details(string id)
		{
			var movieExists = await movieService.ExistsByIdAsync(id);

			MovieDetailsViewModel movie;

			if (!movieExists)
			{
				return NotFound();
			}

			try
			{
				movie = await movieService.GetMovieDetailsByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

				return StatusCode(500);

			}

			return View(movie);
		}

		//public async Task<IActionResult> Rate(string id)
		//{
		//	var movieExists = await movieService.ExistsByIdAsync(id);

		//	MovieDetailsViewModel movie;

		//	if (!movieExists)
		//	{
		//		TempData[ErrorMessage] = "The movie you're trying to rate doesn't exist!";
		//		return NotFound();
		//	}

		//	try
		//	{
		//		movie = await movieService.GetMovieDetailsByIdAsync(id);
		//	}
		//	catch (Exception)
		//	{
		//		ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");

		//		return Redirect(HttpContext.Request.Headers["Referer"]);

		//	}

		//	return View(movie);
		//}

		[AllowAnonymous]
		public async Task<IActionResult> All([FromQuery]MoviePageViewModel model)
		{
			var movieFilterResult = await movieService.GetAllMoviesAsync(model);

			model.TotalItemsCount = movieFilterResult.TotalMoviesCount;
			model.Movies = movieFilterResult.Movies;

			return View(model);

		}

		[AllowAnonymous]
		public async Task<IActionResult> Search()
		{
			//var search = new MovieSearchFormModel
			//{
			//	Genres = await genreService.GetAllGenresAsync()
			//};

			return View();

		}

		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Search(MovieSearchFormModel model)
		{
			if (!ModelState.IsValid)
			{
				//model.Genres = await genreService.GetAllGenresAsync();

				return View(model);
			}

			MovieViewModel[] movies;

			try
			{
				 movies = await movieService.GetAllMoviesBySearchAsync(model);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				return View(model);

			}

			if (movies.Length == 1)
			{
				var movieId = movies.FirstOrDefault()!.Id.ToString();
				var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

				return RedirectToAction(nameof(Details), new {id = movie.Id});
			}

			if (movies.Length == 0)
			{
				TempData[ErrorMessage] = "There are no movies with that name or description that correspond to your search!";
				return RedirectToAction(nameof(Search));
			}

			TempData.Put("MoviesResult", movies);

			return RedirectToAction(nameof(SearchResult));

		}

		[AllowAnonymous]
		public async Task<IActionResult> SearchResult()
		{
			var movies = TempData.Get<MovieViewModel[]>("MoviesResult");
			TempData.Put("MoviesResult", movies); //temporary fix...

			return View(movies);
		}



		public async Task<IActionResult> Add()
		{			
			bool isAdmin = User.IsAdmin();

			if (!isAdmin)
			{
				TempData[ErrorMessage] = "You have to be an admin in order to add a movie!";
				return Unauthorized();
			}

			return View();

		}

		[HttpPost]
		public async Task<IActionResult> Add(MovieAddOrEditFormModel model)
		{
			bool movieExists = await movieService
				.ExistsByNameAndReleaseDate
				(model.Name, model.ReleaseDate.Year, model.ReleaseDate.Month, model.ReleaseDate.Day);

			if (movieExists)
			{
				TempData[ErrorMessage] = "The movie you're trying to add already exists!";
				return View(model);
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			try
			{
				await movieService.AddMovieAsync(model);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				return View(model);

			}

			return RedirectToAction("All", "Movie");

		}

		public async Task<IActionResult> Delete(string id)
		{
			if (!User.IsAdmin())
			{
				TempData[ErrorMessage] = "You have to be an admin in order to delete a movie!";
				return Unauthorized();
			}

			try
			{
				if (!await movieService.ExistsByIdAsync(id))
				{
					TempData[ErrorMessage] = "A movie with that id does not exist!";
					return RedirectToAction(nameof(All));
				}

				await movieService.DeleteAsync(id);
			}
			catch (Exception)
			{
				TempData[ErrorMessage] = "Something went wrong! Please try again or contact support.";
			}

			return RedirectToAction(nameof(All));
		}


		public async Task<IActionResult> Edit(string id)
		{
			if (!User.IsAdmin())
			{
				TempData[ErrorMessage] = "You have to be an admin in order to edit a movie!";
				return Unauthorized();
			}

			if (!await movieService.ExistsByIdAsync(id))
			{
				return BadRequest();
			}

			var movie = await movieService.GetMovieDetailsByIdAsync(id);

			var movieModel = new MovieAddOrEditFormModel()
			{
				Id = movie.Id,
				Name = movie.Name,
				Description = movie.Description,
				ImageUrl = movie.ImageUrl,
				ReleaseDate = movie.ReleaseDate,
				TrailerUrl = movie.TrailerUrl

			};

			return View(movieModel);

		}

		[HttpPost]
		public async Task<IActionResult> Edit(MovieAddOrEditFormModel model)
		{			

			if (!User.IsAdmin())
			{
				TempData[ErrorMessage] = "You must be an admin  to be able to edit a movie!";
				return Unauthorized();
			}


			if (!ModelState.IsValid)
			{
				return View(model);
			}


			try
			{
				await movieService.EditMovie(model);
			}
			catch (Exception)
			{
				ModelState.AddModelError
					(string.Empty, "Unexpected error has occured, while trying to edit movie details, please try again later...");
				return View(model);

			}

			return RedirectToAction(nameof(Details), new { id = model.Id });
		}
	}
}