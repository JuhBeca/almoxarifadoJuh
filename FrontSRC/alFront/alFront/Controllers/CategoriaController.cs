using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace alFront.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var url = "";
<<<<<<< HEAD
            List<Categoria> categoria = new List<Categoria> < CategoriaDTO > ();
=======
            List<CategoriaDTO> categoria = new List<CategoriaDTO>();
            
>>>>>>> 44ff404646f6f2fa4af3e4dae77909eeb8961d21
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
<<<<<<< HEAD
                categoria = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);
                ViewBag.Categorias = categoria;
=======
                categorias = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);
                ViewBag.Categorias = categorias;
>>>>>>> 44ff404646f6f2fa4af3e4dae77909eeb8961d21
            }
            catch (Exception)
            {
                return View();
            }
            return View();
        }
    }
}

