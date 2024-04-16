using TopMovies.Web.ViewModels.UserReviews;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IUserReviewService
	{
		Task<UserReviewViewModel> GetLatestUserReviewByMovieIdAsync(string id);

		Task<UserReviewViewModel[]> GetAllUserReviewsByMovieIdAsync(string id);

		Task<bool> MovieHasUserReviewsByIdAsync(string id);

		Task<bool> UserHasReviewedMovieByUserIdAsync(string userId, string movieId);

		Task AddReviewToMovie(UserReviewAddOrEditFormModel model);
	}
}
