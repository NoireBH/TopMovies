using System.ComponentModel.DataAnnotations;

using static TopMovies.Common.EntityValidationConstants.MovieCharacter;

namespace TopMovies.Data.Models
{
	public class MovieCharacter
	{
		public MovieCharacter()
		{
			Movies = new HashSet<Movie>();
			Actors = new HashSet<Actor>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		[Required]
		public byte[] Image { get; set; } = null!;

		public int Age { get; set; }

		public virtual ICollection<Movie> Movies { get; set; }


		public virtual ICollection<Actor> Actors { get; set; }
	}
}
