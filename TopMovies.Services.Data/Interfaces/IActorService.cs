using TopMovies.Web.ViewModels.Actors;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IActorService
	{
		Task<ActorViewModel[]> GetAllMovieActorsByMovieIdAsync(string id);
		Task<MovieActorAndRoleAddOrEditFormModel> GetActorAndTheirRoleByMovieAndActorAsync(string movieId, int actorId);

		Task<ActorDetailsViewModel> GetActorByIdAsync(int id);

		Task<bool> ExistsByIdAsync(int id);
		Task<bool> ExistsByActorAndMovieIdAsync(int actorId, string movieId);

		Task<ActorMoviesViewModel[]> GetAllOfTheActorsMoviesByIdAsync(int id);

		Task AddActorAndRoleToMovieAsync(MovieActorAndRoleAddOrEditFormModel model, string movieId);

		Task<bool> ExistsByActorAndMovieCharacterNames(string actorName, string movieCharacterName);

		Task DeleteActorAndRoleFromMovieByTheirIdsAsync(string movieId, int actorId);

		Task EditActorAndRoleFromMovieByTheirIdsAsync(MovieActorAndRoleAddOrEditFormModel model, int actorId);

	}
}
