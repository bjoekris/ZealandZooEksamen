using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;



//User story 10 - Bjørn
namespace ZealandZooEksamen.Pages.LagerCRUD
{
    public class IndexLagerModel : PageModel
    {
        //public void OnGet()
        //{
        //}


        private ILagerService _service;
        public IndexLagerModel(ILagerService service)
        {
            _service = service;
        }
       
        public List<Lager> Lageret { get; set; }
        public void OnGet()
        {
         
            
            Lageret = _service.GetAllLager();

            double Omsætning = UdregnIndkøb();

        }

        
        public double UdregnIndkøb()
        {

            var lager = Lageret;


            double sum = 0;
            foreach (var vare in lager)
            {
                sum += vare.LagerIndkøbPris * vare.LagerAntal;
            }


            double average = sum;

            return average;
        }








    }
}
