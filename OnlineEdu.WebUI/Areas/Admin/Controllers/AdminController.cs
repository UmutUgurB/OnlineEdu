using Microsoft.AspNetCore.Mvc;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
   [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AdminController(HttpClient _client) : Controller
    {
        public IActionResult Index()
        {
            //var valus = _client.GetFromJsonAsync()
            return View();
        }
    }
}
