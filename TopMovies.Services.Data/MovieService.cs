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

        public async Task<bool> ExistsByIdAsync(string id)
        {
            return await context.Movies.AnyAsync(m => m.Id.ToString() == id);
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

		public async Task<MovieActorsAndCharactersViewModel> GetMovieActorsAndCharactersByMovieIdAsync(string id)
		{
            var movieActorsAndCharacters = await context.MovieCharacters
                .Where(mc => mc.MovieId.ToString() == id)
				.To<MovieActorsAndCharactersViewModel>()
				.FirstOrDefaultAsync();

            return movieActorsAndCharacters!;
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
