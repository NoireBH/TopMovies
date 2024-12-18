﻿using Microsoft.EntityFrameworkCore;
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
			builder.HasData(SeedUserReviews());
		}

		private UserReview[] SeedUserReviews()
		{

			var userReviews = new HashSet<UserReview>();

			UserReview userReview;

			userReview = new UserReview()
			{
				Id = new Guid("ECD7D309-AA53-44BB-B876-27A6BF213DC5"),
				ApplicationUserId = Guid.Parse("2E5C284D-E571-40C1-97B0-18505632FE70"),
				Comment = "One of the best movies I've ever seen!",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				Rating = 10
				
			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("176697C8-9480-447A-9E86-07B70B0A6585"),
				ApplicationUserId = Guid.Parse("2E5C284D-E571-40C1-97B0-18505632FE70"),
				Comment = "A classic! My only complaint is that the pacing was too slow for my taste.If you have ADHD like me you're gonna have a hard time watching this movie, but i still think it's worth watching!",
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				Rating = 8

			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("FBD5E0AF-4C33-411B-A0B3-88D7863F9D6E"),
				ApplicationUserId = Guid.Parse("84A02B87-DF1D-4F33-BECD-44138F88A11A"),
				Comment = "While good it's extremely overrated",
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				Rating = 7

			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("8EFD4094-5824-434C-9019-EAFB5CCE9510"),
				ApplicationUserId = Guid.Parse("84A02B87-DF1D-4F33-BECD-44138F88A11A"),
				Comment = "Peak fiction, they don't make dark batman movies like this anymore...",
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				Rating = 10

			};

			userReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("96475262-852C-442F-B88C-8642835ECB30"),
				ApplicationUserId = Guid.Parse("84A02B87-DF1D-4F33-BECD-44138F88A11A"),
				Comment = "Not that great. Didn't remain consistent with Batman Begins and was extremely predictable. The plot and action labors along and never reaches a satisfying conclusion. The best thing about this film is the score.\r\n",
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				Rating = 4
				
			};

			userReviews.Add(userReview);

			return userReviews.ToArray();
		}
	}

}
