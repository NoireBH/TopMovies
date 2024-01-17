using System;
using System.Collections.Generic;
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
        }

        public Guid Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public DateTime ReleaseDate { get; set; }

		public string Rating { get; set; } = null!;

		public IEnumerable<Genre> Genres { get; set; }

		public IEnumerable<UserReview> UserReviews { get; set; }

		public byte[] Image { get; set; } = null!;

		public bool IsActive { get; set; }

	}
}
