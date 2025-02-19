using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio_For;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Repositorio_Ent
{
    public class EntradaRepositorio : IEntradaRepositorio
    {
        private readonly Context3 _db;

        public EntradaRepositorio(Context3 db)
        {
            _db = db;
        }

        public void Add(Entrada entrada)
        {

            _db.Entrada.Add(entrada);
            _db.SaveChanges();
        }

        public List<Entrada> GetAll()
        {
            return _db.Entrada.ToList();
        }
    }
}
