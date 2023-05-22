using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;


//Bjørn
namespace ZealandZooEksamen.Pages.SalgsCRUD
{
    public class EditSalgModel : PageModel
    {
        //public void OnGet()
        //{
        //}


        private ISalgService _Service;

        public EditSalgModel(ISalgService service)
        {
            _Service = service;
        }

        [BindProperty]
        public int SalgsId { get; set; }

        [BindProperty]
        public string SalgsNavn { get; set; }

        [BindProperty]
        public double SalgsAntal { get; set; }

        [BindProperty]
        public double SalgsPris { get; set; }




        public void OnGet(int salgsId)
        {
            Salg editSalg = _Service.FindSalg(salgsId);

            SalgsId = editSalg.SalgsId;
            SalgsNavn = editSalg.SalgsNavn;
            SalgsAntal = editSalg.SalgsAntal;
            SalgsPris = editSalg.SalgsPris;
        


        }

        public IActionResult OnPostEdit(int salgsId, Salg salg)
        {
            Salg editSalg = _Service.FindSalg(SalgsId);

            editSalg.SalgsId = SalgsId;
            editSalg.SalgsNavn = SalgsNavn;
            editSalg.SalgsAntal = SalgsAntal;
            editSalg.SalgsPris = SalgsPris;
            


            _Service.EditSalg(salgsId, editSalg);

            return RedirectToPage("IndexSalg");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("IndexSalg");
        }


    }
}
