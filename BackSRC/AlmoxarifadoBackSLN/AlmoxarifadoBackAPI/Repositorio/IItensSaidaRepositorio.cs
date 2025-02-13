using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IItensSaidaRepositorio
    {
        void Add(ItensSaida itenssaida);

        List<ItensSaida> GetAll();
    }
}

