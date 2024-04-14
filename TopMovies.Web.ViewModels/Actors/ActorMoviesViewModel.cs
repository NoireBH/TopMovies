using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Web.ViewModels.Actors
{
	public class ActorMoviesViewModel : IMapFrom<ActorMovie>
	{
		public Guid MovieId { get; set; }

		public string MovieName { get; set; } = null!;

		public string MovieImageUrl { get; set; } = null!;

	}
}
