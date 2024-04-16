using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
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

		public Task<UserReviewViewModel[]> GetAllUserReviewsByMovieIdAsync(string id)
		{
			throw new NotImplementedException();
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
	}
}
