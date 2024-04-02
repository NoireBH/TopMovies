using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.MovieCharacters;

namespace TopMovies.Services.Data
{
	public class MovieCharacterService : IMovieCharacterService
	{
		private readonly TopMoviesDbContext context;

		public MovieCharacterService(TopMoviesDbContext context)
		{
			this.context = context;
		}

		public async Task<MovieCharacterViewModel[]> GetAllMovieCharactersByMovieIdAsync(string id)
		{
			var movieCharacters = await context.MovieCharacters
				.Where((x => x.MovieId.ToString() == id))
				.Select(mc => new MovieCharacterViewModel()
				{
					MovieCharacterId = mc.Id,
					MovieCharacterName = mc.Name,
					MovieCharacterImageUrl = mc.ImageUrl

				})
				.ToArrayAsync();

			return movieCharacters;
		}
	}
}
