using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;


//Bjørn
namespace ZealandZooEksamen.Pages.SalgsCRUD
{
    public class DeleteSalgModel : PageModel
    {
        //public void OnGet()
        //{
        //}


        private ISalgService _service;

        [BindProperty]
        public Salg SletSalg { get; set; }

        public DeleteSalgModel(ISalgService service)
        {
            _service = service;
        }
        public void OnGet(int salgsId)
        {
           
            SletSalg = _service.FindSalg(salgsId);
        }
        public IActionResult OnPostSlet(int salgsId)
        {
            
            _service.DeleteSalg(salgsId);

            return RedirectToPage("IndexSalg");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("IndexSalg");
        }



    }
}
