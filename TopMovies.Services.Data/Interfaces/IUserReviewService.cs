using TopMovies.Data.Models;
using TopMovies.Web.ViewModels.UserReviews;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IUserReviewService
	{
		Task<UserReviewViewModel> GetLatestUserReviewByMovieIdAsync(string id);

		Task<UserReviewViewModel[]> GetAllMovieReviewsByMovieIdAsync(string id);

		Task<bool> MovieHasUserReviewsByIdAsync(string id);

		Task<bool> UserHasReviewedMovieByUserIdAsync(string userId, string movieId);

		Task AddReviewToMovieAsync(UserReviewAddOrEditFormModel model);

		Task<UserReview> GetCurrentUserReviewByUserAndMovieIdAsync(string userId, string movieId);
		Task<UserReviewMineViewModel[]> GetAllReviewsOfUserByIdAsync(string userId);
		Task EditReviewAsync(UserReviewAddOrEditFormModel model);

		Task DeleteByUserAndMovieIdAsync(string userId, string movieId);
	}
}
