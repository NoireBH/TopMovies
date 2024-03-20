using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.MoviesMovieCharacters;

namespace TopMovies.Services.Data
{
	public class MovieCharacterService : IMovieCharacterService
	{
		private readonly TopMoviesDbContext context;

		public MovieCharacterService(TopMoviesDbContext context)
		{
			this.context = context;
		}

		public async Task<MovieMovieCharacterViewModel[]> GetAllMovieCharactersByMovieIdAsync(string id)
		{
			var movieCharacters = await context.MovieMovieCharacters
				.Where((x => x.MovieId.ToString() == id))
				.Select(mc => new MovieMovieCharacterViewModel()
				{
					MovieCharacterId = mc.MovieCharacterId,
					Name = mc.MovieCharacter.Name,
					ImageUrl = mc.MovieCharacter.ImageUrl

				})
				.ToArrayAsync();

			return movieCharacters;
		}
	}
}
