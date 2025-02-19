using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio_For;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Repositorio_For
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly Context2 _db;

        public FornecedorRepositorio(Context2 db)
        {
            _db = db;
        }

        public void Add(Fornecedor fornecedor)
        {

            _db.Fornecedor.Add(fornecedor);
            _db.SaveChanges();
        }

        public List<Fornecedor> GetAll()
        {
            return _db.Fornecedor.ToList();
        }

    }
}
