using System.ComponentModel.DataAnnotations;

using static TopMovies.Common.EntityValidationConstants.Actor;

namespace TopMovies.Data.Models
{
	public class Actor
    {
        public Actor()
        {
            Movies = new HashSet<Movie>();
            MovieCharacters = new HashSet<MovieCharacter>();
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
        public string ImagePath { get; set; } = null!;

        [Required]
        public DateTime YearBorn { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

        public virtual ICollection<MovieCharacter> MovieCharacters { get; set; }
    }
}
