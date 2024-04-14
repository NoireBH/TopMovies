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
			return await context.Actors.AnyAsync(m => m.Id == id);
		}

		public async Task<ActorDetailsViewModel> GetMovieCharacterByIdAsync(int id)
		{
			var actor = await context.Actors
				.Where(a => a.Id == id)
				.To<ActorDetailsViewModel>()
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
	}
}
