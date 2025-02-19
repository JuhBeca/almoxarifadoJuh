using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
<<<<<<< HEAD
using AlmoxarifadoBackAPI.Repositorio;
=======
using AlmoxarifadoBackAPI.Repositorio_sai;
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
    public class SaidaController : ControllerBase
    {
        private readonly ISaidaRepositorio _db;
<<<<<<< HEAD
        private object saida;

        public SaidaController(ISaidaRepositorio db)
        {
            _db = db;
        }



=======
        public SaidaController(ISaidaRepositorio db)
        {
            _db =db;
      
        }

>>>>>>> LayoutPadrão
        [HttpGet("/listaSaida")]
        public IActionResult listaSaida()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Saida")]
<<<<<<< HEAD
        public IActionResult listaSaida(SaidaDTO saida)
        {
            return Ok(_db.GetAll().Where(x => x.IdSaida == saida.IdSaida));
        }

        [HttpPost("/addSaida")]
        public IActionResult addSaida(SaidaCadastroDTO saida)
        {

            var novaSaida = new Saida()
            {
                IdSec = saida.IdSec,
                DataSaida = saida.DataSaida,
                Observação = saida.Observação

            };
            //_categorias.Add(novaCategoria);
            _db.Add(novaSaida);
            return Ok("Cadastro com Sucesso");
        }
=======
        public IActionResult listaEntrada(SaidaDTO saida)
        {
            return Ok(_db.GetAll().Where(x=>x.Codigo==saida.Codigo));
        }

        [HttpPost("/criarSaida")]
        public IActionResult criarSaida(SaidaCadastroDTO saida)
        {

            var novaSaida = new Saida()
            {               
                Descricao = saida.Descricao
            };
            //_categorias.Add(novaSaida);
            _db.Add(novaSaida);
            return Ok("Cadastro com Sucesso");
        }

        



>>>>>>> LayoutPadrão
    }
}
