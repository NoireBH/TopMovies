using System.ComponentModel.DataAnnotations;

namespace TopMovies.Web.ViewModels.Genres
{
	public class MovieGenreAddOrEditFormModel
	{
        public MovieGenreAddOrEditFormModel()
        {
			Genres = new HashSet<GenreFormModel>();
        }

        public Guid MovieId { get; set; } 

		[Required]
		public int GenreId { get; set; }

		public IEnumerable<GenreFormModel> Genres { get; set; } = null!;

	}
}
