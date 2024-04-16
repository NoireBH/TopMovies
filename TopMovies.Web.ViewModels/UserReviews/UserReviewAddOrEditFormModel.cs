using System.ComponentModel.DataAnnotations;
using static TopMovies.Common.EntityValidationConstants.UserReview;

namespace TopMovies.Web.ViewModels.UserReviews
{
	public class UserReviewAddOrEditFormModel
	{

		public string ApplicationUserId { get; set; } = null!;

		public string MovieId { get; set; } = null!;

		[Required]
		[StringLength(CommentMaxLength, MinimumLength = CommentMinLength)]
		public string Comment { get; set; } = null!;

	}
}
