using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio_sai
{
    public class SaidaRepositorio : ISaidaRepositorio
    {
        private readonly Context4 _db;

        public SaidaRepositorio(Context4 db)
        {
            _db = db;
        }

        public void Add(Saida saida)
        {

            _db.Saida.Add(saida);
            _db.SaveChanges();
        }

        public List<Saida> GetAll()
        {
            return _db.Saida.ToList();
        }
    }
}
