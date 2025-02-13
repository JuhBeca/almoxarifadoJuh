using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensSaidaController : ControllerBase
    {
        private readonly IItensSaidaRepositorio _db;
        private object itenssaida;

        public ItensSaidaController(IItensSaidaRepositorio db)
        {
            _db = db;
        }



        [HttpGet("/listaitenssaida")]
        public IActionResult listaItensSaida()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/ItensSaida")]
        public IActionResult listaItensSaida(ItensSaidaDTO itenssaida)
        {
            return Ok(_db.GetAll().Where(x => x.IdItensSaida == itenssaida.IdItensSaida));
        }

        [HttpPost("/addItensSaida")]
        public IActionResult addItensSaida(ItensSaidaCadastroDTO itensSaida)
        {

            var novoItensSaida = new ItensSaida()
            {
                Id = itensSaida.Id,
                IdSaida = itensSaida.IdSaida,
                Quantidade = itensSaida.Quantidade,
                Preco = itensSaida.Preco,
                Total = itensSaida.Total

            };
            //_categorias.Add(novaCategoria);
            _db.Add(novoItensSaida);
            return Ok("Cadastro com Sucesso");
        }
    }
}
