﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TopMovies.Common.EntityValidationConstants.UserReview;

namespace TopMovies.Data.Models
{
	public class UserReview
	{

		[Key]
        public Guid Id { get; set; }

		[ForeignKey(nameof(ApplicationUser))]
		public Guid ApplicationUserId { get; set; }

		public ApplicationUser ApplicationUser { get; set; } = null!;


		[Range(RatingMin, RatingMax)]
		public int Rating { get; set; }

		[MaxLength(CommentMaxLength)]
		public string Comment { get; set; } = null!;

		public Guid MovieId { get; set; }

		public virtual Movie Movie { get; set; } = null!;
    }
}
