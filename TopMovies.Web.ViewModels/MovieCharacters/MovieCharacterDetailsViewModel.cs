using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;

namespace TopMovies.Web.ViewModels.MovieCharacters
{
	public class MovieCharacterDetailsViewModel : IMapFrom<MovieCharacter>
	{
		public MovieCharacterDetailsViewModel()
		{
			Movies = new HashSet<ActorMoviesViewModel>();
		}

		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public string ImageUrl { get; set; } = null!;

		public int Age { get; set; } 

		public IEnumerable<ActorMoviesViewModel> Movies { get; set; } = null!;	

	}
}
