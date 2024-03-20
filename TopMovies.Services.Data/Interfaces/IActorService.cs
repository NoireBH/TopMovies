using TopMovies.Web.ViewModels.ActorMovieCharacter;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IActorService
	{
		Task<ActorAndMovieCharacterViewModel[]> GetActorsWithTheirCharactersByMovieId(string id);

		Task<ActorInMovieViewModel[]> GetAllMovieActorsByMovieIdAsync(string id);
	}
}
