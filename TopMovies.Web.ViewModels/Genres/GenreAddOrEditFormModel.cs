using System.ComponentModel.DataAnnotations;
using static TopMovies.Common.EntityValidationConstants.Genre;

namespace TopMovies.Web.ViewModels.Genres
{
	public class GenreAddOrEditFormModel
	{
		public int Id { get; set; }

		[Required]
		[StringLength(NameMaxLength, MinimumLength = NameMinLength)]
		public string Name { get; set; } = null!;
	}
}
