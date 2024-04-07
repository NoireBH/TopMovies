using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TopMovies.Web.Controllers
{
	public class HelpController : BaseController
	{
		[AllowAnonymous]
		public IActionResult QandA()
		{
			return View();
		}
	}
}
