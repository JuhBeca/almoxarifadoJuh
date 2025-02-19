using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Repositorio_Sec
{
    public class ISecretariaRepositorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
