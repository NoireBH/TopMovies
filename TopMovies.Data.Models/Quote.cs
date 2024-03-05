using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class Quote
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Description { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(MovieCharacter))]
		public int MovieCharacterId { get; set; }

		public MovieCharacter MovieCharacter { get; set; } = null!;

	}
}
