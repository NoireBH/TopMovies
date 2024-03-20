using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
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

		public  async Task<MovieActorsAndCharactersViewModel> GetActorsWithTheirCharactersByMovieId(string id)
		{
			var movieInfo = await (from m in context.Movies
							 where m.Id.ToString() == id
							 select new MovieActorsAndCharactersViewModel
							 {
								 Actors = from ma in m.ActorsMovies
										  select new ActorInMovieViewModel()
										  {
											  ActorId = ma.ActorId,
											  ActorName = ma.Actor.Name,
											  ActorImageUrl = ma.Actor.ImageUrl
										  },
								 Characters = from mc in m.MovieMovieCharacters
											  select new MovieMovieCharacterViewModel()
											  {
												  MovieCharacterId = mc.MovieCharacterId,
												  Name = mc.MovieCharacter.Name,
												  ImageUrl = mc.MovieCharacter.ImageUrl
											  }
							 }).FirstOrDefaultAsync();

			return movieInfo!;
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
