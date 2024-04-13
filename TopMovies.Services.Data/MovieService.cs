using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data;
using TopMovies.Data.Models;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Home;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Services.Data
{
    public class MovieService : IMovieService
    {
        private readonly TopMoviesDbContext context;

        public MovieService(TopMoviesDbContext context)
        {
            this.context = context;
        }

		public async Task AddMovieAsync(MovieAddOrEditFormModel movie)
		{
            Movie newMovie = new Movie()
            {
                Id = movie.Id,
                Name = movie.Name,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
                ImageUrl = movie.ImageUrl,
                TrailerUrl = movie.TrailerUrl,
                MovieGenres = movie.MovieGenres
            };

            await context.AddAsync(newMovie);
            await context.SaveChangesAsync();
		}

		public async Task DeleteAsync(string houseId)
		{
			var movie = await context.Movies.FirstOrDefaultAsync(h => h.Id.ToString() == houseId);

			context.Movies.Remove(movie!);
			await context.SaveChangesAsync();

		}

		public async Task<bool> ExistsByIdAsync(string id)
        {
            return await context.Movies.AnyAsync(m => m.Id.ToString() == id);
        }

		public Task<bool> ExistsByNameAndReleaseDate(string name, string year, string month, string day)
		{
			throw new NotImplementedException();
		}

		public async Task<MovieViewModel[]> GetAllMoviesAsync()
		{
            return await context.Movies
                .To<MovieViewModel>()
                .ToArrayAsync();
		}

		public async Task<FeaturedMoviesViewModel[]> GetFeaturedMoviesAsync()
        {
            Movie[] allMovies = await context.Movies.AsNoTracking().OrderBy(_ => Guid.NewGuid()).Take(3).ToArrayAsync();

            FeaturedMoviesViewModel[] featuredMovies = allMovies
                .Select(m => new FeaturedMoviesViewModel
                {
                    Id = m.Id.ToString(),
                    Name = m.Name,
                    ImageUrl = m.ImageUrl
                }).ToArray();

            return featuredMovies;
        }

		public async Task<MovieActorsAndCharactersViewModel[]> GetMovieActorsAndCharactersByMovieIdAsync(string id)
		{
            var movieActorsAndCharacters = await context.MovieCharacters
                .Where(mc => mc.MovieId.ToString() == id)
				.To<MovieActorsAndCharactersViewModel>()
				.ToArrayAsync();

            return movieActorsAndCharacters!;
		}

		public async Task<int> GetMovieCountAsync()
		{
			return await context.Movies.CountAsync();
		}

		public async Task<MovieDetailsViewModel> GetMovieDetailsByIdAsync(string id)
        {
            var movie = await context.Movies
                .Where(m => m.Id.ToString() == id)
                .To<MovieDetailsViewModel>()
                .FirstOrDefaultAsync();

            return movie!;

        }
    }
}
