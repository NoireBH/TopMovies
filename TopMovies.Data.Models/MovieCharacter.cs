using System.ComponentModel.DataAnnotations;

using static TopMovies.Common.EntityValidationConstants.MovieCharacter;

namespace TopMovies.Data.Models
{
	public class MovieCharacter
	{
		public MovieCharacter()
		{
			MovieMovieCharacters = new HashSet<MovieMovieCharacter>();
			ActorMovieCharacters = new HashSet<ActorMovieCharacter>();
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
		public string ImageUrl { get; set; } = null!;

		public int Age { get; set; }

		public virtual ICollection<MovieMovieCharacter> MovieMovieCharacters { get; set; }

		public virtual ICollection<ActorMovieCharacter> ActorMovieCharacters { get; set; }
	}
}
