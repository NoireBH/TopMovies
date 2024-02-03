using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class MovieGenre
	{
		[ForeignKey(nameof(Movie))]
		public int MovieId { get; set; }

		public Movie Movie { get; set; } = null!;

		[ForeignKey(nameof(Genre))]
		public int GenreId { get; set; }

		public Genre Genre { get; set; } = null!;
	}
}
