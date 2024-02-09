using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data;
using TopMovies.Data.Models;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Web.ViewModels.Home;

namespace TopMovies.Services.Data
{
	public class MovieService : IMovieService
	{
		private readonly TopMoviesDbContext dbContext;

		public MovieService(TopMoviesDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<FeaturedMoviesViewModel[]> GetFeaturedMoviesAsync()
		{
			Movie[] allMovies = await dbContext.Movies.AsNoTracking().ToArrayAsync();
			allMovies.OrderBy(_ => Guid.NewGuid()).Take(3);

			FeaturedMoviesViewModel [] featuredMovies = allMovies
				.Select(m => new FeaturedMoviesViewModel
				{
					Id = m.Id,
					Name = m.Name,
					ImageUrl = m.ImageUrl
				}).ToArray();

			return featuredMovies;
		}
	}
}
