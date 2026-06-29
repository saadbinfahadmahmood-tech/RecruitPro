using Microsoft.AspNetCore.Mvc;

namespace Recruit_Pro.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
