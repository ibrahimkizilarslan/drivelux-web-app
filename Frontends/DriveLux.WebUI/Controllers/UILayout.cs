using Microsoft.AspNetCore.Mvc;

namespace DriveLuxProject.WebUI.Controllers
{
    public class UILayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
