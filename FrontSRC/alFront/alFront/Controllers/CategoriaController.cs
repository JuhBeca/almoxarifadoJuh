using Microsoft.AspNetCore.Mvc;

namespace alFront.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var url = "";

            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception)
            {
                return View();
            }
            return View();
        }
    }
}
