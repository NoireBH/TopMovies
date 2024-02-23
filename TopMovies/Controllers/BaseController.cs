using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TopMovies.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
