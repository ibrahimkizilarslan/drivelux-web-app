using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DriveLuxProject.DTO.AboutDTOs;
using DriveLuxProject.WebUI.ViewComponents.UILayoutViewComponents;

namespace DriveLuxProject.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _clientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7290/api/Abouts");

            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDTO>>(jsonData); 
                return View(values);

            }
            return View();
        }   

    }
}
