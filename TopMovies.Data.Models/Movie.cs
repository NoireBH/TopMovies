using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class Movie
	{
        public Movie()
        {
            Genres = new HashSet<Genre>();
			UserReviews = new HashSet<UserReview>();
			Actors = new HashSet<Actor>();
        }

        public Guid Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public DateTime ReleaseDate { get; set; }

		public double Rating { get; set; }

		public IEnumerable<Genre> Genres { get; set; }

		public IEnumerable<UserReview> UserReviews { get; set; }

		public IEnumerable<Actor> Actors { get; set; }

		public byte[] Image { get; set; } = null!;

		public bool IsActive { get; set; }

	}
}
