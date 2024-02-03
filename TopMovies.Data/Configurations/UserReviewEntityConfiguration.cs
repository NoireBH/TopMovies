using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
	public class UserReviewEntityConfiguration : IEntityTypeConfiguration<UserReview>
	{
		public void Configure(EntityTypeBuilder<UserReview> builder)
		{
			throw new NotImplementedException();
		}

		private void SeedUserReviews()
		{

			var userReviews = new HashSet<UserReview>();

			UserReview userReview;

			userReview = new UserReview()
			{

			};
		}
	}

}
