using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.Home;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IMovieService
	{
		Task<FeaturedMoviesViewModel[]> GetFeaturedMoviesAsync();
	}
}
