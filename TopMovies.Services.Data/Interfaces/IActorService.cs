using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.Genres;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IActorService
	{
		Task<ActorViewModel[]> GetAllMovieActorsByMovieIdAsync(string id);

		Task<ActorDetailsViewModel> GetActorByIdAsync(int id);

		Task<bool> ExistsByIdAsync(int id);

		Task<ActorMoviesViewModel[]> GetAllOfTheActorsMoviesByIdAsync(int id);

		Task AddActorAndRoleToMovie(MovieActorAndRoleAddOrEditFormModel model, string movieId);

		Task<bool> ExistsByActorAndMovieCharacterNames(string actorName, string movieCharacterName);
	}
}
