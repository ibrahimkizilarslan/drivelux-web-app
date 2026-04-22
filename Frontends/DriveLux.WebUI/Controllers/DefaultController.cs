using Microsoft.AspNetCore.Mvc;

namespace DriveLuxProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
