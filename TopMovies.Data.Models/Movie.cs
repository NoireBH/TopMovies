using System.ComponentModel.DataAnnotations;

using static TopMovies.Common.EntityValidationConstants.Movie;

namespace TopMovies.Data.Models
{
	public class Movie
	{
        public Movie()
        {
            Genres = new HashSet<Genre>();
			UserReviews = new HashSet<UserReview>();
			Actors = new HashSet<Actor>();
			MovieCharacters = new HashSet<MovieCharacter>();
        }

		[Key]
        public Guid Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		[Required]
		public DateTime ReleaseDate { get; set; }

		[Required]
		[Range(typeof(double), RatingMin, RatingMax)]
		public double Rating { get; set; }

		public virtual IEnumerable<Genre> Genres { get; set; }

		public virtual IEnumerable<UserReview> UserReviews { get; set; }

		public virtual IEnumerable<Actor> Actors { get; set; }

		public virtual IEnumerable<MovieCharacter> MovieCharacters { get; set; }

		public byte[] Image { get; set; } = null!;

		public bool IsActive { get; set; }

	}
}
