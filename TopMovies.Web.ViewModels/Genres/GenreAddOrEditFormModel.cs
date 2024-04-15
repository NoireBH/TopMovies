using System.ComponentModel.DataAnnotations;

namespace TopMovies.Web.ViewModels.Genres
{
	public class GenreAddOrEditFormModel
	{
		[Required]
		public string Name { get; set; } = null!;
	}
}
