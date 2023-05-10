using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;


//User story 10 - Bjørn
namespace ZealandZooEksamen.Pages.LagerCRUD
{
    public class EditLagerModel : PageModel
    {
        //public void OnGet()
        //{
        //}

        private ILagerService _Service;

        public EditLagerModel(ILagerService service)
        {
            _Service = service;
        }

        [BindProperty]
        public int LagerId { get; set; }

        [BindProperty]
        public string LagerNavn { get; set; }

        [BindProperty]
        public double LagerAntal { get; set; }

        [BindProperty]
        public double LagerPris { get; set; }

        [BindProperty]
        public double LagerIndkøbPris { get; set; }

 
  

        //Huskeliste
        //LagerId = lagerId;
        //    LagerNavn = lagerNavn;
        //    LagerAntal = lagerAntal;
        //    LagerPris = lagerPris;
        //    LagerIndkøbPris = lagerIndkøbPris;

        public void OnGet(int lagerId)
        {
            Lager editLager = _Service.FindLager(lagerId);

            LagerId = editLager.LagerId;
            LagerNavn = editLager.LagerNavn;
            LagerAntal = editLager.LagerAntal;
            LagerPris = editLager.LagerPris;
            LagerIndkøbPris = editLager.LagerIndkøbPris;

        
        }

        public IActionResult OnPostEdit(int lagerId)
        {
            Lager editLager = _Service.FindLager(LagerId);

            editLager.LagerId = LagerId;
            editLager.LagerNavn = LagerNavn;
            editLager.LagerAntal = LagerAntal;
            editLager.LagerPris = LagerPris;
            editLager.LagerIndkøbPris = LagerIndkøbPris;
           

            _Service.EditLager(editLager);

            return RedirectToPage("IndexLager");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("IndexLager");
        }





    }
}
