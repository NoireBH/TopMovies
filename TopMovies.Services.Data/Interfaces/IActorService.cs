using TopMovies.Web.ViewModels.Actors;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IActorService
	{
		Task<ActorViewModel[]> GetAllMovieActorsByMovieIdAsync(string id);
	}
}
