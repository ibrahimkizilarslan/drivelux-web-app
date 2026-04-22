using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DriveLuxProject.DTO.BannerDTOs;


namespace DriveLuxProject.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCoverUILayoutComponentPartial : ViewComponent
    {

        private readonly IHttpClientFactory _clientFactory;

        public _DefaultCoverUILayoutComponentPartial(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7290/api/Banners");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBannerDTO>>(jsonData);
                return View(values);
            }
            return View();
            
        }
    }
}
