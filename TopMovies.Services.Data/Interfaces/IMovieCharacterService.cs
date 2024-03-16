using TopMovies.Web.ViewModels.MoviesMovieCharacters;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IMovieCharacterService
	{
		Task<MovieMovieCharacterViewModel[]> GetAllMovieCharactersByMovieIdAsync(string id);

	}
}
