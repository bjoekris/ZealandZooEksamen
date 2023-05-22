using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Model
{

    //Bjørn

    public class UtilityUdregner
    {

        private ILagerService _lagerService;
        private ISalgService _salgService;

        public UtilityUdregner(ILagerService lagerService, ISalgService salgService)
        {
            _lagerService = lagerService;
            _salgService = salgService;
        }


        public double UdregnIndkøb()
        {

        

            double sum = 0;
            foreach (var vare in _lagerService.GetAllLager())
            {
                sum += vare.LagerIndkøbPris * vare.LagerAntal;
            }


            double average = sum;

            return average;
        }

        public double UdregnOmsætning()
        {

            

            double sum = 0;
            foreach (var vare in _salgService.GetAllSalg())
            {
                sum += vare.SalgsPris * vare.SalgsAntal;
            }


            double udregning = sum;

            return udregning;
        }

        public double UdregnResultat()
        {
            double omsætning = UdregnOmsætning();
            double indkøb = UdregnIndkøb();

            double resultat = omsætning + indkøb;

            return resultat;


        }





    }
}
