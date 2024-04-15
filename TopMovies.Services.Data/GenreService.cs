using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Data.Models;
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

		public async Task AddGenreAsync(GenreAddOrEditFormModel movie)
		{
			Genre newGenre = new Genre()
			{
				Name = movie.Name
			};

			await context.Genres.AddAsync(newGenre);
			await context.SaveChangesAsync();
		}

		public async Task AddGenreToMovieAsync(MovieGenreAddOrEditFormModel model, string movieId)
		{
			//var genre = await context.Genres
			//	.Where(g => g.Id == model.GenreId)
			//	.FirstOrDefaultAsync();

			//var movie = await context.Movies
			//	.Where(m => m.Id.ToString() == movieId)
			//	.FirstOrDefaultAsync();

			var movieGenre = new MovieGenre()
			{
				GenreId = model.GenreId,
				MovieId = new Guid(model.MovieId)
			};

			await context.MovieGenres.AddAsync(movieGenre);
			await context.SaveChangesAsync();
		}

		public async Task<bool> ExistsByNameAsync(string name)
		{
			return await context.Genres.AnyAsync(m => m.Name == name);
		}

		public async Task<bool> ExistsByIdAsync(int id)
		{
			return await context.Genres.AnyAsync(m => m.Id == id);
		}

		public async Task<GenreFormModel[]> GetAllGenresAsync()
		{
			var genres = await context.Genres
			.To<GenreFormModel>()	
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

		public async Task<bool> MovieGenreExistsByGenreAndMovieId(int genreId, string movieId)
		{
			return await context.MovieGenres.AnyAsync(m => m.GenreId == genreId && m.MovieId.ToString() == movieId);
		}

		public async Task DeleteGenreFromMovieByGenreAndMovieIdAsync(int genreId, string movieId)
		{
			var movieGenre = await context.MovieGenres
				.FirstOrDefaultAsync
				(h => h.GenreId == genreId && h.MovieId.ToString() == movieId);

			context.MovieGenres.Remove(movieGenre!);
			await context.SaveChangesAsync();

		}
	}
}
