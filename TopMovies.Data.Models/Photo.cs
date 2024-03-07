using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class Photo
	{
		[Key]
        public int Id { get; set; }

		[Required]
		public string ImageURl { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(Movie))]
		public Guid MovieId { get; set; }

		public Movie Movie { get; set; } = null!;
	}
}
