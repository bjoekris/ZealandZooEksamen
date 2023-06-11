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
        private ILagerService _service;
        private ISalgService _salgService;

        [BindProperty]
        public Salg OpretSalg { get; set; }

        public CreateSalgModel(ISalgService salgService, ILagerService service)
        {
            _salgService = salgService;
            _service = service;

        }

        public IActionResult OnPostOpret()
        {
            _salgService.CreateSalg(OpretSalg);

            return RedirectToPage("IndexSalg");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("IndexSalg");
        }



        public List<Lager> Lageret { get; set; }

        public void OnGet()
        {


            Lageret = _service.GetAllLager();
        }






    }
}
