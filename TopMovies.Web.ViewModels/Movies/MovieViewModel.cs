using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieViewModel : IMapFrom<Movie>
	{
		public Guid Id { get; set; }

		public string Name { get; set; } = null!;

		public string ImageUrl { get; set; } = null!;

		public string YearOfRelease { get; set; } = null!;
	}
}
