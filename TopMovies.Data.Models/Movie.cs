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
        }

        public Guid Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public DateTime DateAired { get; set; }

		public string Rating { get; set; } = null!;

		public IEnumerable<Genre> Genres { get; set; }

		public IEnumerable<UserReview> UserReviews { get; set; }

	}
}
