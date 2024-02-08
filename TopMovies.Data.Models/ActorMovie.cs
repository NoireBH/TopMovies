using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class ActorMovie
	{
		[ForeignKey(nameof(Actor))]
		public int ActorId { get; set; }

		public Actor Actor { get; set; } = null!;

		[ForeignKey(nameof(Movie))]
		public int MovieId { get; set; }

		public Movie Movie { get; set; } = null!;
	}
}
