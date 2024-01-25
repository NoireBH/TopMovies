using TopMovies.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TopMovies.Data.Models
{
	public class UserReview
	{

		[Key]
        public Guid Id { get; set; } 
		public int ApplicationUserId { get; set; }

		public ApplicationUser ApplicationUser { get; set; } = null!;


		public int Rating { get; set; }

		public string Comment { get; set; } = null!;

		public Guid MovieId { get; set; }

		public virtual Movie Movie { get; set; } = null!;
    }
}
