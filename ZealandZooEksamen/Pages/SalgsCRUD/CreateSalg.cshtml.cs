using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.SalgsCRUD
{

    //Bjørn

    public class CreateSalgModel : PageModel
    {
        //public void OnGet()
        //{
        //}

        //Interface implementering
        private ILagerService _service;
        private ISalgService _salgService;

        //Salgsproperty
        [BindProperty]
        public Salg OpretSalg { get; set; }

        //Konstruktør (depency injection) [program.cs]
        public CreateSalgModel(ISalgService salgService, ILagerService service)
        {
            _salgService = salgService;
            _service = service;

        }


        //Metode (fra interface)
        public IActionResult OnPostOpret()
        {
            _salgService.CreateSalg(OpretSalg);

            return RedirectToPage("IndexSalg");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("IndexSalg");
        }


        //Lager property
        
        public List<Lager> Lageret { get; set; }

        //metode, finder værdier fra service, service>lageret, lageret i View
        public void OnGet()
        {
            Lageret = _service.GetAllLager();
        }






    }
}
