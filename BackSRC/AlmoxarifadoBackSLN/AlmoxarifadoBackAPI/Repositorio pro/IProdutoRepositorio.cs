using AlmoxarifadoBackAPI.Models;


namespace AlmoxarifadoBackAPI.Repositorio_pro
{
    public interface IProdutoRepositorio 
    {
        void Add(Produto produto);

        List<Produto> GetAll();


    }
}

