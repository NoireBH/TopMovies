using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
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

        public Task<MovieGenreViewModel[]> GetAllGenresAsync()
		{
			var genres = context.Genres
				.Select(g => new MovieGenreViewModel()
			{
				GenreId = g.Id,
				GenreGenreName = g.Name,
			}).ToArrayAsync();

			return genres;
		}

		public Task<MovieGenreViewModel[]> GetMovieGenresByMovieIdAsync(string id)
		{
			var movieGenres = context.MovieGenres
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
