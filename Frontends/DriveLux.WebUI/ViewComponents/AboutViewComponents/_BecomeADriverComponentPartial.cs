using Microsoft.AspNetCore.Mvc;

namespace DriveLuxProject.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecomeADriverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    }
}
