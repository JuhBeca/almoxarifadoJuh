using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
<<<<<<< HEAD
using AlmoxarifadoBackAPI.Repositorio;
=======
using AlmoxarifadoBackAPI.Repositorio_Ent;
>>>>>>> LayoutPadrão
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
<<<<<<< HEAD
    [Route("api/[controller]")]
=======
    [Route("[controller]")]
>>>>>>> LayoutPadrão
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly IEntradaRepositorio _db;
<<<<<<< HEAD
        private object entrada;

        public EntradaController(IEntradaRepositorio db)
        {
            _db = db;
        }



        [HttpGet("/listaentrada")]
=======
        public EntradaController(IEntradaRepositorio db)
        {
            _db =db;
      
        }

        [HttpGet("/listaEntrada")]
>>>>>>> LayoutPadrão
        public IActionResult listaEntrada()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Entrada")]
        public IActionResult listaEntrada(EntradaDTO entrada)
        {
<<<<<<< HEAD
            return Ok(_db.GetAll().Where(x => x.IdEnt == entrada.IdEnt));
        }

        [HttpPost("/addEntrada")]
        public IActionResult addEntrada(EntradaCadastroDTO entrada)
        {

            var novaEntrada = new Entrada()
            {
               IdForn = entrada.IdForn,
               DataEnt = entrada.DataEnt,
               Observação = entrada.Observação
               
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novaEntrada);
            return Ok("Cadastro com Sucesso");
        }
=======
            return Ok(_db.GetAll().Where(x=>x.Codigo==entrada.Codigo));
        }

        [HttpPost("/criarentrada")]
        public IActionResult criarEntrada(EntradaCadastroDTO entrada)
        {

            var novaEntrada = new Entrada()
            {               
                Descricao = entrada.Descricao
            };
            //_categorias.Add(novaEntrada);
            _db.Add(novaEntrada);
            return Ok("Cadastro com Sucesso");
        }

        



>>>>>>> LayoutPadrão
    }
}
