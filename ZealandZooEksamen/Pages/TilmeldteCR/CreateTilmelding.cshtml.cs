using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.TilmeldteCR
{
    public class CreateTilmeldingModel : PageModel
    {


        private ITilmeldteService _tilmeldteService;

        [BindProperty]
        public Tilmeldte OpretTilmeldte { get; set; }

        public CreateTilmeldingModel(ITilmeldteService tilmeldteService)
        {
            _tilmeldteService = tilmeldteService;
        }

        public IActionResult OnPostOpret()
        {
            _tilmeldteService.CreateTilmeldte(OpretTilmeldte);

            return RedirectToPage("IndexTilmelding");
        }
        public IActionResult OnPostBekræft()
        {
            _tilmeldteService.CreateTilmeldte(OpretTilmeldte);
            return RedirectToPage("IndexTilmelding");
        }
    }
}
