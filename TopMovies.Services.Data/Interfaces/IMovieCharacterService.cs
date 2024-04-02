using TopMovies.Web.ViewModels.MovieCharacters;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IMovieCharacterService
	{
		Task<MovieCharacterViewModel[]> GetAllMovieCharactersByMovieIdAsync(string id);

	}
}
