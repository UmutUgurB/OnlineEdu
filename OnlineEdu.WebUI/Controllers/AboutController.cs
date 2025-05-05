using Microsoft.AspNetCore.Mvc;

namespace OnlineEdu.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
