using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DriveLuxProject.DTO.BlogDTOs;

namespace DriveLuxProject.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public BlogController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Blogs";
            ViewBag.v2 = "Yazarlarımızın Blogsı";
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7290/api/Blogs/GetAllBlogsWithAuthorsList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDTOs>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> BlogDetails(int id)
        {
            ViewBag.v1 = "Blogs";
            ViewBag.v2 = "Blog Details Blog Detayı ve Yorumları Comments";
            ViewBag.blogid = id;
            return View();
        }
    }
}
