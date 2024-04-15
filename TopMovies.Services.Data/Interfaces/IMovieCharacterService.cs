using TopMovies.Web.ViewModels.MovieCharacters;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IMovieCharacterService
	{
		Task<MovieCharacterViewModel[]> GetAllMovieCharactersByMovieIdAsync(string id);

		Task<MovieCharacterDetailsViewModel> GetMovieCharacterByIdAsync(int id);

		Task<bool> ExistsByIdAsync(int id);

		Task<bool> ExistsByNameAsync(string name);

	}
}
