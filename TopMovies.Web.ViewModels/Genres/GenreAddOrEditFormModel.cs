using System.ComponentModel.DataAnnotations;

namespace TopMovies.Web.ViewModels.Genres
{
	public class GenreAddOrEditFormModel
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;
	}
}
