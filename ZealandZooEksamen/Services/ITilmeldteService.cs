using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public interface ITilmeldteService
    {
        public List<Tilmeldte> GetAllTilmeldte();

        public Tilmeldte FindTilmeldte(int id);

        public Tilmeldte CreateTilmeldte(Tilmeldte t);

    }
}
