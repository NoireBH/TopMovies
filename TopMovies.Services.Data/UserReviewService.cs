using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Data.Models;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.UserReviews;

namespace TopMovies.Services.Data
{
	public class UserReviewService : IUserReviewService
	{
		private readonly TopMoviesDbContext context;

		public UserReviewService(TopMoviesDbContext context)
		{
			this.context = context;
		}

		public async Task AddReviewToMovieAsync(UserReviewAddOrEditFormModel model)
		{
			var userReview = new UserReview()
			{
				ApplicationUserId = new Guid(model.ApplicationUserId),
				MovieId = new Guid(model.MovieId),
				Comment = model.Comment
			};

			await context.UserReviews.AddAsync(userReview);
			await context.SaveChangesAsync();
		}

		public async Task DeleteByUserAndMovieIdAsync(string userId, string movieId)
		{
			var userReview = await context.UserReviews
				.Where(ur => ur.ApplicationUserId.ToString() == userId && ur.MovieId.ToString() == movieId)
				.FirstOrDefaultAsync();

			context.UserReviews.Remove(userReview!);
			await context.SaveChangesAsync();

		}

		public async Task EditReviewAsync(UserReviewAddOrEditFormModel model)
		{
			var userReview = await context.UserReviews
				.Where(ur => ur.ApplicationUserId.ToString() == model.ApplicationUserId && ur.MovieId.ToString() == model.MovieId)
				.FirstOrDefaultAsync();

			userReview!.Comment = model.Comment;

			await context.SaveChangesAsync();
		}

		public async Task<UserReviewViewModel[]> GetAllUserReviewsByMovieIdAsync(string id)
		{
			var userReviews = await context.UserReviews
				.Where(a => a.MovieId.ToString() == id)
				.To<UserReviewViewModel>()
				.ToArrayAsync();

			return userReviews;
		}

		public async Task<UserReview> GetCurrentUserReviewByUserAndMovieIdAsync(string userId, string movieId)
		{
			var userReview = await context.UserReviews
				.Where(ur => ur.ApplicationUserId.ToString() == userId && ur.MovieId.ToString() == movieId)
				.FirstOrDefaultAsync();

			return userReview!;
		}

		public async Task<UserReviewViewModel> GetLatestUserReviewByMovieIdAsync(string id)
		{
			var latestReview = await context.UserReviews
				.Where(u => u.MovieId.ToString() == id)
				.To<UserReviewViewModel>()
				.FirstOrDefaultAsync();

			return latestReview!;
		}

		public async Task<bool> MovieHasUserReviewsByIdAsync(string id)
		{
			return await context.UserReviews.AnyAsync(ur => ur.MovieId.ToString() == id);
		}

		public async Task<bool> UserHasReviewedMovieByUserIdAsync(string userId, string movieId)
		{
			return await context.UserReviews.AnyAsync(ur => ur.ApplicationUserId.ToString() == userId && ur.MovieId.ToString() == movieId);
		}
	}
}
