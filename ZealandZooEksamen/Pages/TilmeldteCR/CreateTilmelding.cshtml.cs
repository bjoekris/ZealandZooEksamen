using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.TilmeldteCR
{
    public class CreateTilmeldingModel : PageModel
    {
        //public void OnGet()
        //{
        //}

        private ITilmeldteService _tilmeldteService;

        [BindProperty]
        public Tilmeldte OpretTilmelding { get; set; }

        public CreateTilmeldingModel(ITilmeldteService tilmeldteService)
        {
            _tilmeldteService = tilmeldteService;
        }

        public IActionResult OnPostOpret()
        {
            _tilmeldteService.CreateTilmeldte(OpretTilmelding);

            return RedirectToPage("Index");
        }
        public IActionResult OnPostBekræft()
        {
            return RedirectToPage("Index");
        }
    }
}
