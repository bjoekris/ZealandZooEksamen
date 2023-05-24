using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;




namespace ZealandZooEksamen.Pages.TilmeldingCRUD
{
    //Mathilde

    public class TilmeldingCreateModel : PageModel
    {
        //public void OnGet()
        //{
        //}



        private INyhedsbrevService _nyhedsbrevService;

        [BindProperty]
        public Nyhedsbrev OpretNyhedsbrev{ get; set; }

        public TilmeldingCreateModel(INyhedsbrevService nyhedsbrevService)
        {
            _nyhedsbrevService = nyhedsbrevService;
        }

        public IActionResult OnPostOpret()
        {
            _nyhedsbrevService.CreateNyhedsbrev(OpretNyhedsbrev);

            return RedirectToPage("TilmeldingIndex");
        }
        public IActionResult OnPostBekræft()
        {
            return RedirectToPage("TilmeldingIndex");
        }
    }

    }




