using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;
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

		public async Task<bool> ExistsByIdAsync(int id)
		{
			return await context.MovieCharacters.AnyAsync(m => m.Id == id);
		}

		public async Task<MovieCharacterDetailsViewModel> GetMovieCharacterByIdAsync(int id)
		{
			var actor = await context.MovieCharacters
				.Where(a => a.Id == id)
				.To<MovieCharacterDetailsViewModel>()
				.FirstOrDefaultAsync();

			return actor!;
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

		public async Task<bool> ExistsByNameAsync(string name)
		{
			return await context.MovieCharacters.AnyAsync(m => m.Name == name);
		}
	}
}
