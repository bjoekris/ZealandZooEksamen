using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Pages.LagerCRUD;


namespace ZealandZooEksamen.Pages.SalgsCRUD
{

    //Bj�rn
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

            Oms�tning = Udregner.UdregnOms�tning();

            Resultat = Udregner.UdregnResultat();

        }

        public double Oms�tning { get; set; }
        public double Resultat { get; set; }


        //public double UdregnOms�tning()
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
        //    double oms�tning = UdregnOms�tning();
        //    double indk�b = UdregnIndk�b();

        //    double resultat = oms�tning - indk�b;

        //    return resultat;


        //}



    }
}
