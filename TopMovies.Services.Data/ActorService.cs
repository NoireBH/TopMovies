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
		private readonly IMovieCharacterService movieCharacterService;

		public ActorService(TopMoviesDbContext context, IMovieCharacterService movieCharacterService)
		{
			this.context = context;
			this.movieCharacterService = movieCharacterService;
		}

		public async Task<Dictionary<ActorMovieViewModel, MovieMovieCharacterViewModel>> GetActorsWithTheirCharactersByMovieIdAsync(string id)
		{
			var actorsAndCharacters = await context.ActorMovieCharacters
				.Where(amc => amc.Actor.ActorsMovies.Where(am => am.MovieId.ToString() == id))

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
