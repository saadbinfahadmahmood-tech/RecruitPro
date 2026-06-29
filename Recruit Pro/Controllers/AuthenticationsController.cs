using Microsoft.AspNetCore.Mvc;

namespace Recruit_Pro.Controllers
{
    public class AuthenticationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
