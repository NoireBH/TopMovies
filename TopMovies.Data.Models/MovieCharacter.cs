﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TopMovies.Common.EntityValidationConstants.MovieCharacter;

namespace TopMovies.Data.Models
{
	public class MovieCharacter
	{
		public MovieCharacter()
		{
			Quotes = new HashSet<Quote>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		public string ImageUrl { get; set; } = null!;

		public int Age { get; set; }

		[Required]
		[ForeignKey(nameof(Actor))]
		public int ActorId { get; set; }

		public Actor Actor { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(Movie))]
		public Guid MovieId { get; set; }

		public Movie Movie { get; set; } = null!;

		public virtual ICollection<Quote> Quotes { get; set; }

	}
}
