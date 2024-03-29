﻿using System.ComponentModel.DataAnnotations;
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
			MovieMovieCharacters = new HashSet<MovieMovieCharacter>();
			Photos = new List<Photo>();
		}

		[Key]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		public DateTime ReleaseDate { get; set; }

		[Range(typeof(double), RatingMin, RatingMax)]
		public double Rating { get; set; }

		[Required]
		public string ImageUrl { get; set; } = null!;

		public bool IsActive { get; set; }

		[Required]
		public string TrailerUrl { get; set; } = null!;

		public ICollection<Photo> Photos {  get; set; }

		public virtual ICollection<MovieGenre> MovieGenres { get; set; }

		public virtual IEnumerable<UserReview> UserReviews { get; set; }

		public virtual ICollection<ActorMovie> ActorsMovies { get; set; }

		public virtual ICollection<MovieMovieCharacter> MovieMovieCharacters { get; set; }

	}
}
