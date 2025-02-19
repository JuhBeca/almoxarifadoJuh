using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio_pro
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
       
        
            private readonly Context1 _db;

            public ProdutoRepositorio(Context1 db)
            {
                _db = db;
            }

            public void Add(Produto produto)
            {

                _db.Produto.Add(produto);
                _db.SaveChanges();
            }

            public List<Produto> GetAll()
            {
                return _db.Produto.ToList();
            }

        
    }
}
