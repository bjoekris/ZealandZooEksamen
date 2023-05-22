using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public interface ITilmeldteService
    {
        public List<Tilmeldte> GetAllTilmeldte();

        public Tilmeldte FindTilmeldte(int tilmeldingId);

        public Tilmeldte CreateTilmeldte(Tilmeldte t);

    }
}
