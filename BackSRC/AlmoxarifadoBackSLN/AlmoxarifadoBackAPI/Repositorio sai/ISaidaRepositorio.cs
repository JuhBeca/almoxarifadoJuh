using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Repositorio_sai
{
    public interface ISaidaRepositorio 
    {
        void Add(Saida saida);

        List<Saida> GetAll();


    }
}

