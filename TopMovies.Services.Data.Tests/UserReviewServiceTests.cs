using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels;
using System.Reflection;
using TopMovies.Data.Models;
using TopMovies.Web.ViewModels.UserReviews;

namespace TopMovies.Services.Data.Tests
{
	public class UserReviewServiceTests
	{
		private DbContextOptions<TopMoviesDbContext> dbOptions;
		private TopMoviesDbContext context;
		private IUserReviewService service;

		[SetUp]
		public void SetUp()
		{
			dbOptions = new DbContextOptionsBuilder<TopMoviesDbContext>()
				.UseInMemoryDatabase("TopMoviesInMemory" + Guid.NewGuid())
				.Options;
			context = new TopMoviesDbContext(dbOptions);
			service = new UserReviewService(context);

			AutoMapperConfig.RegisterMappings(
			typeof(ActorDetailsViewModel).GetTypeInfo().Assembly,
			typeof(ErrorViewModel).GetTypeInfo().Assembly);

			Seed();
		}

		[TearDown]
		public void TearDownDb() => context.Dispose();

		[Test]
		public async Task AddReviewToMovieAsyncShouldIncreaseCount()
		{
			var userReview = new UserReviewAddOrEditFormModel()
			{
				ApplicationUserId = "E11F771C-1B10-41EB-81BC-0683DD00B080",
				Comment = "One of the best movies I've ever seen!",
				MovieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD"

			};

			int expectedCount = 4;
			await service.AddReviewToMovieAsync(userReview);

			int actualCount = context.UserReviews.Count();

			Assert.That(actualCount, Is.EqualTo(expectedCount));
		}

		[Test]
		public async Task AddReviewToMovieAsyncShouldAddCorrectMovie()
		{
			var userReview = new UserReviewAddOrEditFormModel()
			{
				ApplicationUserId = "E11F771C-1B10-41EB-81BC-0683DD00B080",
				Comment = "One of the best movies I've ever seen!",
				MovieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD"

			};
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();
			string appUserId = "E11F771C-1B10-41EB-81BC-0683DD00B080".ToLower();
			string expectedComment = "One of the best movies I've ever seen!";
			await service.AddReviewToMovieAsync(userReview);


			var actualReview = await context.UserReviews
				.Where(ur => ur.MovieId.ToString() == movieId && ur.ApplicationUserId.ToString() == appUserId)
				.FirstOrDefaultAsync();

			Assert.That(actualReview!.Comment, Is.EqualTo(expectedComment));
			Assert.That(actualReview.MovieId.ToString(), Is.EqualTo(movieId));
			Assert.That(actualReview.ApplicationUserId.ToString(), Is.EqualTo(appUserId));
		}

		[Test]
		public async Task DeleteByUserAndMovieIdAsyncShouldDecreaseCount()
		{

			int expectedCount = 2;
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();
			string appUserId = "E11F771C-1B10-41EB-81BC-0683DD00B080".ToLower();

			var users = context.Users.ToList();
			var usersReviews = context.UserReviews.ToList();
			await service.DeleteByUserAndMovieIdAsync(appUserId, movieId);
			int actualCount = context.UserReviews.Count();

			Assert.That(actualCount, Is.EqualTo(expectedCount));
		}

		private void Seed()
		{
			Movie movie;

			movie = new Movie()
			{
				Id = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				Name = "The Shawshank Redemption",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				ReleaseDate = new DateTime(1994, 9, 10),
				TrailerUrl = "https://www.youtube.com/embed/NmzuHjWmXOc",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg",

			};

			context.Movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				Name = "The Godfather",
				Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
				ReleaseDate = new DateTime(1972, 3, 14),
				TrailerUrl = "https://www.youtube.com/embed/sY1S34973zA",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg"
			};

			context.Movies.Add(movie);

			var user = new ApplicationUser();

			user = new ApplicationUser()
			{
				Id = Guid.Parse("E11F771C-1B10-41EB-81BC-0683DD00B080"),
				UserName = "firstUser",
				NormalizedUserName = "FIRSTUSER",
				Email = "FirstUser@abv.bg",
				NormalizedEmail = "FIRSTUSER@ABV.BG",
				EmailConfirmed = true,
			};

			context.Users.Add(user);

			user = new ApplicationUser
			{
				Id = Guid.Parse("2110C067-48D9-441A-A1EB-C723466B60C0"),
				UserName = "secondtUser",
				NormalizedUserName = "SECONDUSER",
				Email = "SecondUser@abv.bg",
				NormalizedEmail = "SECONDUSER@ABV.BG",
				EmailConfirmed = true,
			};

			context.Users.Add(user);

			user = new ApplicationUser
			{
				Id = Guid.Parse("129D8177-95E3-404F-872E-EB94FE803BD1"),
				UserName = "thirdUser",
				NormalizedUserName = "THIRDUSER",
				Email = "ThirdUser@abv.bg",
				NormalizedEmail = "THIRDUSER@ABV.BG",
				EmailConfirmed = true,
			};

			context.Users.Add(user);

			UserReview userReview;

			userReview = new UserReview()
			{
				Id = new Guid("ECD7D309-AA53-44BB-B876-27A6BF213DC5"),
				ApplicationUserId = Guid.Parse("2E5C284D-E571-40C1-97B0-18505632FE70"),
				Comment = "One of the best movies I've ever seen!",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")

			};

			context.UserReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("176697C8-9480-447A-9E86-07B70B0A6585"),
				ApplicationUserId = Guid.Parse("129D8177-95E3-404F-872E-EB94FE803BD1"),
				Comment = "A classic! My only complaint is that the pacing was too slow for my taste.If you have ADHD like me you're gonna have a hard time watching this movie, but i still think it's worth watching!",
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6")

			};

			context.UserReviews.Add(userReview);

			userReview = new UserReview()
			{
				Id = new Guid("FBD5E0AF-4C33-411B-A0B3-88D7863F9D6E"),
				ApplicationUserId = Guid.Parse("129D8177-95E3-404F-872E-EB94FE803BD1"),
				Comment = "While good it's extremely overrated",
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6")

			};

			context.UserReviews.Add(userReview);

			context.SaveChanges();

		}
	}
}
