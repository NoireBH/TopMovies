using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.ActorsMovies;
using TopMovies.Web.ViewModels.MoviesMovieCharacters;

namespace TopMovies.Services.Data
{
	public class ActorService : IActorService
	{
		private readonly TopMoviesDbContext context;

		public ActorService(TopMoviesDbContext context)
		{
			this.context = context;
		}

		public Task<Dictionary<ActorMovieViewModel, MovieMovieCharacterViewModel>> GetActorsWithTheirCharactersByMovieIdAsync(string id)
		{
			var actorsAndCharacters = new Dictionary<ActorMovieViewModel, MovieMovieCharacterViewModel>();



		}

		public async Task<ActorMovieViewModel[]> GetAllMovieActorsByMovieIdAsync(string id)
		{
			var actors = await context.ActorMovies
				.Where((x => x.MovieId.ToString() == id))
				.Select(am => new ActorMovieViewModel
				{
					ActorId = am.ActorId,
					ActorName = am.Actor.Name,
					ActorImageUrl = am.Actor.ImageUrl,
					MovieId = am.MovieId.ToString()

				})
				.ToArrayAsync();

			return actors;
		}
	}
}
