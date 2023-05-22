using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Pages.LagerCRUD;


namespace ZealandZooEksamen.Pages.SalgsCRUD
{

    //Bjørn
    public class IndexSalgModel : PageModel
    {
        //public void OnGet()
        //{
        //}

        private ISalgService _service;
        private ILagerService _lagerService;
        public IndexSalgModel(ISalgService service,ILagerService lagerService)
        {
            _service = service;
            _lagerService = lagerService;

        }

        public List<Salg> Salget { get; set; }

        public void OnGet()
        {
            UtilityUdregner Udregner = new UtilityUdregner(_lagerService, _service);

            Salget = _service.GetAllSalg();

            Omsætning = Udregner.UdregnOmsætning();

            Resultat = Udregner.UdregnResultat();

        }

        public double Omsætning { get; set; }
        public double Resultat { get; set; }


        //public double UdregnOmsætning()
        //{

        //    var salg = Salget;


        //    double sum = 0;
        //    foreach (var vare in salg)
        //    {
        //        sum += vare.SalgsPris * vare.SalgsAntal;
        //    }


        //    double udregning = sum;

        //    return udregning;
        //}

        //public double UdregnResultat()
        //{
        //    double omsætning = UdregnOmsætning();
        //    double indkøb = UdregnIndkøb();

        //    double resultat = omsætning - indkøb;

        //    return resultat;


        //}



    }
}
