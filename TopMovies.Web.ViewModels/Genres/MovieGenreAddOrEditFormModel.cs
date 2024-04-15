using System.ComponentModel.DataAnnotations;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Genres
{
	public class MovieGenreAddOrEditFormModel : IMapFrom<MovieGenre>
	{
        public MovieGenreAddOrEditFormModel()
        {
			Genres = new HashSet<GenreFormModel>();
        }

		public string MovieId { get; set; } = null!;

		[Required]
		[Display(Name = "Genre")]
		public int GenreId { get; set; }

		public IEnumerable<GenreFormModel> Genres { get; set; } = null!;

	}
}
