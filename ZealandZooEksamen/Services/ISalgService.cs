using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    //Hvilke metoder findes

    public interface ISalgService
    {
        public List<Salg> GetAllSalg();

        public Salg DeleteSalg(int salgsId);

        public Salg FindSalg(int salgsId);

        public Salg CreateSalg(Salg sa);

        public Salg EditSalg(int salgsId, Salg salg);





    }
}
