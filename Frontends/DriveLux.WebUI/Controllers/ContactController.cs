using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DriveLuxProject.DTO.ContactDTOs;
using System.Text;

namespace DriveLuxProject.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public ContactController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> Index(CreateContactDTO createContactDTO)
        {
            var client = _clientFactory.CreateClient();
            createContactDTO.SendDate = DateTime.Now;
            var jsonData = JsonConvert.SerializeObject(createContactDTO);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7290/api/Contacts",content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Default");
            }
            return View();
        }

    }
}
