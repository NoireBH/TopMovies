using Microsoft.AspNetCore.Mvc;

namespace TopMovies.Web.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
    }
}
