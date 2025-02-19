using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Repositorio_For
{
    public interface IFornecedorRepositorio
    {
        void Add(Fornecedor fornecedor);

        List<Fornecedor> GetAll();

    }
}
