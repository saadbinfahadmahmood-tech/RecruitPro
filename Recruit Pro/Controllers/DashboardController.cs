using Microsoft.AspNetCore.Mvc;

namespace Recruit_Pro.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
