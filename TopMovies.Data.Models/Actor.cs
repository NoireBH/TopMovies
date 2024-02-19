using System.ComponentModel.DataAnnotations;

using static TopMovies.Common.EntityValidationConstants.Actor;

namespace TopMovies.Data.Models
{
	public class Actor
    {
        public Actor()
        {
            ActorsMovies = new HashSet<ActorMovie>();
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

        [Required]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<ActorMovie> ActorsMovies { get; set;}

        public virtual ICollection<ActorMovieCharacter> ActorMovieCharacters { get; set; }
    }
}
