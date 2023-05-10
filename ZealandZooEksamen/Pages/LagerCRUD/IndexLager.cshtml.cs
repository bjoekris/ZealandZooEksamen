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

            double Omsætning = UdregnOmsætning(1);

        }

        public double UdregnOmsætning(int lagerId)
        {

            var lager = Lageret.Where(s => s.LagerId == lagerId);


            double sum = 0;
            foreach (var vare in lager)
            {
                sum += vare.LagerPris * vare.LagerAntal;
            }


            double average = sum;

            return average;
        }





    }
}
