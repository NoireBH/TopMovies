using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.Actors;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieActorsAndCharactersViewModel
	{
		public IEnumerable<ActorInMovieViewModel> Actors { get; set; } = null!;
	}
}
