using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.ActorMovieCharacters;
using TopMovies.Web.ViewModels.Actors;
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

		public  Task<> GetActorsWithTheirCharactersByMovieIdAsync(string id)
		{
			var movieInfo = (from m in context.Movies
							 where m.Id.ToString() == id
							 select new
							 {
								 Actors = from ma in m.ActorsMovies
										  select new ActorInMovieViewModel()
										  {
											  ActorName = ma.Actor.Name,
											  ActorId = ma.ActorId
										  },
								 Characters = from mc in m.MovieMovieCharacters
											  select new
											  {
												  CharacterName = mc.MovieCharacter.Name
											  }
							 }).FirstOrDefault();

			return movieInfo;
		}

		public async Task<ActorInMovieViewModel[]> GetAllMovieActorsByMovieIdAsync(string id)
		{
			var actors = await context.ActorMovies
				.Where((x => x.MovieId.ToString() == id))
				.Select(am => new ActorInMovieViewModel
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
