using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DriveLuxProject.DTO.ServiceDTOs;

namespace DriveLuxProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {

      public IActionResult Index()
        {
            ViewBag.v1 = "Services";
            ViewBag.v2 = "Servicesimiz";
            return View();
        }
    }
}
