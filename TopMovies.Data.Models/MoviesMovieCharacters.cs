using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class MoviesMovieCharacters
	{
		[ForeignKey(nameof(Movie))]
		public Guid MovieId { get; set; }

		public Movie Movie { get; set; } = null!;

		[ForeignKey(nameof(MovieCharacter))]
		public int MovieCharacterId { get; set; }

		public MovieCharacter MovieCharacter { get; set; } = null!;
	}
}
