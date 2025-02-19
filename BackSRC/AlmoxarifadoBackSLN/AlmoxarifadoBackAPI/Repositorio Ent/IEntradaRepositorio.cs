using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Repositorio_Ent
{
    public interface IEntradaRepositorio 
    {
        
        
            void Add(Entrada entrada);

            List<Entrada> GetAll();


        
    }
}
