using System.ComponentModel.DataAnnotations;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;
using static TopMovies.Common.EntityValidationConstants.Genre;

namespace TopMovies.Web.ViewModels.Genres
{
	public class GenreFormModel : IMapFrom<Genre>
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;
	}
}
