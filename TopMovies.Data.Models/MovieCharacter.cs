using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TopMovies.Common.EntityValidationConstants.MovieCharacter;

namespace TopMovies.Data.Models
{
	public class MovieCharacter
	{

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		public string ImageUrl { get; set; } = null!;

		public int Age { get; set; }

		[Required]
		public int ActorId { get; set; }
		
		[ForeignKey(nameof(ActorId))]
		public Actor Actor { get; set; } = null!;

		[Required]
		public Guid MovieId { get; set; }
		
		[ForeignKey(nameof(MovieId))]
		public Movie Movie { get; set; } = null!;

	}
}
