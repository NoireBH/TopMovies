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
				Id = new Guid("ECD7D309-AA53-44BB-B876-27A6BF213DC5"),
				ApplicationUserId = Guid.Parse("735B0AD2-82A1-4394-A521-2B1DC921C737"),
				Rating = 10,
				Comment = "One of the best movies I've ever seen!",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")
				
			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("ECD7D309-AA53-44BB-B876-27A6BF213DC5"),
				ApplicationUserId = Guid.Parse("735B0AD2-82A1-4394-A521-2B1DC921C737"),
				Rating = 10,
				Comment = "One of the best movies I've ever seen!",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")

			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("ECD7D309-AA53-44BB-B876-27A6BF213DC5"),
				ApplicationUserId = Guid.Parse("735B0AD2-82A1-4394-A521-2B1DC921C737"),
				Rating = 10,
				Comment = "One of the best movies I've ever seen!",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")

			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("ECD7D309-AA53-44BB-B876-27A6BF213DC5"),
				ApplicationUserId = Guid.Parse("735B0AD2-82A1-4394-A521-2B1DC921C737"),
				Rating = 10,
				Comment = "One of the best movies I've ever seen!",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")

			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("ECD7D309-AA53-44BB-B876-27A6BF213DC5"),
				ApplicationUserId = Guid.Parse("735B0AD2-82A1-4394-A521-2B1DC921C737"),
				Rating = 10,
				Comment = "One of the best movies I've ever seen!",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")

			};

			userReviews.Add(userReview);
		}
	}

}
