using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class ApplicationUserUserReview
	{
		[ForeignKey(nameof(ApplicationUser))]
		public Guid ApplicationUserId { get; set; }

		public ApplicationUser ApplicationUser { get; set; } = null!;

		[ForeignKey(nameof(UserReview))]
		public int UserReviewId { get; set; }

		public UserReview UserReview { get; set; } = null!;
	}
}
