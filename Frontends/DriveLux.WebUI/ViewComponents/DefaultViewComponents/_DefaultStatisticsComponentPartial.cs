using Microsoft.AspNetCore.Mvc;

namespace DriveLuxProject.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
