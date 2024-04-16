using Microsoft.AspNetCore.Mvc;
using TopMovies.Services.Data.Interfaces;

namespace TopMovies.Web.Controllers
{
	public class UserReviewController : BaseController
	{
		private readonly IUserReviewService userReviewService;

		public UserReviewController(IUserReviewService userReviewService)
		{
			this.userReviewService = userReviewService;
		}

		public IActionResult AddToMovie()
		{


			return View();
		}
	}
}
