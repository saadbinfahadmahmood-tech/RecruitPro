using Microsoft.AspNetCore.Mvc;

namespace Recruit_Pro.Controllers
{
    public class AdvertisementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
