using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public interface ITilmeldteService
    {
        public List<Tilmeldte> GetAllTilmeldte();

        public Tilmeldte FindTilmeldte(int tilmeldingId);

        public Tilmeldte CreateTilmeldte(Tilmeldte tilmeldte, int eventId);

        public Tilmeldte DeleteTilmelding(int tilmeldingId);

    }
}
