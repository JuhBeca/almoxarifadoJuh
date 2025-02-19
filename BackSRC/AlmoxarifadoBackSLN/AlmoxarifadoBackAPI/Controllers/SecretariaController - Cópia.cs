﻿using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio_sai;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SaidaController : ControllerBase
    {
        private readonly ISaidaRepositorio _db;
        public SaidaController(ISaidaRepositorio db)
        {
            _db =db;
      
        }

        [HttpGet("/listaSaida")]
        public IActionResult listaSaida()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Saida")]
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

        



    }
}
