using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.UserReviews
{
	public class UserReviewMineViewModel : IMapFrom<UserReview>, IMapFrom<Movie>
	{
		public string Id { get; set; } = null!;

		public string ApplicationUserId { get; set; } = null!;

		public string MovieId { get; set; } = null!;

		public string MovieName { get; set; } = null!;

		public string ApplicationUserUserName { get; set; } = null!;

		public string Comment { get; set; } = null!;
	}
}
