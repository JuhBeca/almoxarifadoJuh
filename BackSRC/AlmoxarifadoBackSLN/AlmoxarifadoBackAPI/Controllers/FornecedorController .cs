using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio_For;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepositorio _db;
        public FornecedorController(IFornecedorRepositorio db)
        {
            _db =db;
      
        }

        [HttpGet("/listafornecedor")]
        public IActionResult listaFornecedor()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Fornecedor")]
        public IActionResult listaProduto(FornecedorDTO fornecedor)
        {
            return Ok(_db.GetAll().Where(x=>x.Codigo==fornecedor.Codigo));
        }

        [HttpPost("/criarfornecedor")]
        public IActionResult criarFornecedor(FornecedorCadastroDTO fornecedor)
        {

            var novaFornecedor = new Fornecedor()
            {               
                nome = fornecedor.nome
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novaFornecedor);
            return Ok("Cadastro com Sucesso");
        }

        



    }
}
