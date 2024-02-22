using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.Home;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IMovieService
	{
		Task<FeaturedMoviesViewModel[]> GetFeaturedMoviesAsync();

		Task<bool> ExistsByIdAsync(string  id);

		Task<MovieDetailsViewModel> GetMovieDetailsByIdAsync(string id);
	}
}
