using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

//User story 10 - Bjørn
namespace ZealandZooEksamen.Pages.LagerCRUD
{
    public class CreateLagerModel : PageModel
    {
        //public void OnGet()
        //{
        //}



        private ILagerService _lagerService;

        [BindProperty]
        public Lager OpretLager { get; set; }

        public CreateLagerModel(ILagerService lagerService)
        {
            _lagerService = lagerService;
        }

        public IActionResult OnPostOpret()
        {
            _lagerService.CreateLager(OpretLager);

            return RedirectToPage("IndexLager");
        }
        public IActionResult OnPostBekræft()
        {
            return RedirectToPage("IndexLager");
        }

    }
}






