﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data;
using TopMovies.Data.Models;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.Home;
using TopMovies.Web.ViewModels.Movie;

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

			FeaturedMoviesViewModel [] featuredMovies = allMovies
				.Select(m => new FeaturedMoviesViewModel
				{
					Id = m.Id,
					Name = m.Name,
					ImageUrl = m.ImageUrl
				}).ToArray();

			return featuredMovies;
		}

        public async Task<MovieDetailsViewModel> GetMovieDetailsByIdAsync(string id)
        {
			var movie = await context.Movies.FirstOrDefaultAsync(m => m.Id.ToString() == id);
        }
    }
}
