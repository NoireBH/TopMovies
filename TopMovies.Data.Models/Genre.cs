using System.ComponentModel.DataAnnotations;
using static TopMovies.Common.EntityValidationConstants.Genre;

namespace TopMovies.Data.Models
{
	public class Genre
	{
		public Genre()
		{
			Movies = new HashSet<Movie>();
			MovieGenres = new HashSet<MovieGenre>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		public virtual ICollection<Movie> Movies { get; set; }

		public virtual ICollection<MovieGenre> MovieGenres { get; set; }
	}
}
