using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Genres;
using TopMovies.Web.ViewModels.MoviesGenres;

namespace TopMovies.Services.Data
{
	public class GenreService : IGenreService
	{
		private readonly TopMoviesDbContext context;

        public GenreService(TopMoviesDbContext context)
        {
            this.context = context;
        }

        public async Task<GenreViewModel[]> GetAllGenresAsync()
		{
			var genres = await context.Genres
			.To<GenreViewModel>()	
			.ToArrayAsync();

			return genres;
		}

		public async Task<MovieGenreViewModel[]> GetMovieGenresByMovieIdAsync(string id)
		{
			var movieGenres = await context.MovieGenres
				.Where(x => x.MovieId.ToString() == id)
				.Select(x => new MovieGenreViewModel()
				{
					GenreId = x.GenreId,
					GenreGenreName = x.Genre.Name
				})
				.ToArrayAsync();

			return movieGenres;
		}
	}
}
