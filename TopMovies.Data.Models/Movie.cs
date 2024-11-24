using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TopMovies.Common.EntityValidationConstants;
using static TopMovies.Common.EntityValidationConstants.Movie;

namespace TopMovies.Data.Models
{
	public class Movie
	{
		public Movie()
		{
			UserReviews = new HashSet<UserReview>();
			ActorsMovies = new HashSet<ActorMovie>();
			MovieGenres = new HashSet<MovieGenre>();
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
		public string ImageUrl { get; set; } = null!;

		[Required]
		public string TrailerUrl { get; set; } = null!;

		[Required]
		[NotMapped]
		public double Rating
		{
			get
			{
				if (UserReviews.Any(ur => ur.MovieId == Id))
				{
					return UserReviews.Where(ur => ur.MovieId == Id).Select(r => r.Rating)
					.Average();
				}

				return 0;

			}
		}



		public virtual ICollection<MovieGenre> MovieGenres { get; set; }

		public virtual IEnumerable<UserReview> UserReviews { get; set; }

		public virtual ICollection<ActorMovie> ActorsMovies { get; set; }

		public virtual ICollection<MovieCharacter> MovieCharacters { get; set; }

	}
}
