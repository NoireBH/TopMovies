using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Data.Models;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.ActorMovieCharacter;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.Movies;
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

		public async Task<ActorAndMovieCharacterViewModel[]> GetActorsWithTheirCharactersByMovieId(string id)
		{
			var actorsAndTheirCharacters = await (from movie in context.Movies
												  where movie.Id.ToString() == id
												  select new ActorAndMovieCharacterViewModel()
												  {
													  ActorsAndCharacters = from movieActor in movie.ActorsMovies																			
																			join actorCharacter in context.ActorMovieCharacters
																			on movieActor.ActorId equals actorCharacter.ActorId
																			select new ActorAndMovieCharacterInfoViewModel()
																			{
																				ActorId = movieActor.ActorId,
																				ActorName = movieActor.Actor.Name,
																				ActorImageUrl = movieActor.Actor.ImageUrl,
																				MovieCharacterId = actorCharacter.MovieCharacter.Id,
																				MovieCharacterName = actorCharacter.MovieCharacter.Name,

																			}
												  }).ToArrayAsync();

			return actorsAndTheirCharacters!;
		}

		public async Task<ActorInMovieViewModel[]> GetAllMovieActorsByMovieIdAsync(string id)
		{
			var actors = await context.ActorMovies
				.Where((x => x.MovieId.ToString() == id))
				.Select(am => new ActorInMovieViewModel
				{
					ActorId = am.ActorId,
					ActorName = am.Actor.Name,
					ActorImageUrl = am.Actor.ImageUrl

				})
				.ToArrayAsync();

			return actors;
		}
	}
}
