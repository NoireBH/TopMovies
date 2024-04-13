﻿using System.ComponentModel.DataAnnotations;
using TopMovies.Data.Models;
using TopMovies.Web.ViewModels.Genres;
using static TopMovies.Common.EntityValidationConstants.Movie;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieAddOrEditFormModel
	{
        public MovieAddOrEditFormModel()
        {
			MovieGenres = new HashSet<MovieGenre>();
			Genres = new HashSet<GenreFormModel>();
			Id = new Guid();

		}

		public Guid Id { get; set; }

        [Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		[Display(Name = "Release date")]
		public DateTime ReleaseDate { get; set; }

		[Required]
		[Display(Name = "Image link")]
		public string ImageUrl { get; set; } = null!;

		[Required]
		[Display(Name = "Youtube trailer link")]
		public string TrailerUrl { get; set; } = null!;

		public virtual ICollection<GenreFormModel> Genres { get; set; } = null!;

		public virtual ICollection<MovieGenre> MovieGenres { get; set; } = null!;
	}
}
