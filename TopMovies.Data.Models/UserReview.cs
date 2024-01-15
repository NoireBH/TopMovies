using TopMovies.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class UserReview
	{
		public Guid Id { get; set; } 

		public ApplicationUser User { get; set; } = null!;

		public int UserId { get; set; }

		public int Rating { get; set; }

		public string Comment { get; set; } = null!;
	}
}
