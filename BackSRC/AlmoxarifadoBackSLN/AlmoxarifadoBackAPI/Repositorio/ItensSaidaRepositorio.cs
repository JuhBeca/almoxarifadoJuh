using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ItensSaidaRepositorio : IItensSaidaRepositorio
    {

        private readonly Context _db;

        public ItensSaidaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(ItensSaida obj)
        {

            _db.ItensSaida.Add(obj);
            _db.SaveChanges();
        }

        public List<ItensSaida> GetAll()
        {
            return _db.ItensSaida.ToList();
        }
    }
}
