using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DriveLuxProject.DTO.CarDTOs;
using DriveLuxProject.DTO.CarPricingDTOs;
using DriveLuxProject.DTO.ServiceDTOs;

namespace DriveLuxProject.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public CarController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Our Fleet";
            ViewBag.v2 = "Select Your Vehicle";
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7290/api/CarPricings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarPricingWithCarDTOs>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
