using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class MoviePhoto
	{
		[ForeignKey(nameof(Actor))]
		public int PhotoId { get; set; }

		public Photo Photo { get; set; } = null!;

		[ForeignKey(nameof(Movie))]
		public Guid MovieId { get; set; }

		public Movie Movie { get; set; } = null!;
	}
}
