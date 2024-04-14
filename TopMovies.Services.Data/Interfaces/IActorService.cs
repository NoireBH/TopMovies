using TopMovies.Web.ViewModels.Actors;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IActorService
	{
		Task<ActorViewModel[]> GetAllMovieActorsByMovieIdAsync(string id);

		Task<ActorDetailsViewModel> GetActorByIdAsync(int id);

		Task<bool> ExistsByIdAsync(int id);

		Task<ActorMoviesViewModel[]> GetAllOfTheActorsMoviesByIdAsync(int id);
	}
}
