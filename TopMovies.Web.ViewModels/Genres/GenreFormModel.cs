using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Genres
{
	public class GenreFormModel : IMapFrom<Genre>
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;
	}
}
