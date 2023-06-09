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

        [BindProperty]
        public int eventId { get; set; }

        public void OnGet(int eventId)
        {
            this.eventId = eventId;
        }

        public IActionResult OnPostOpret(int eventId)
        {
            _tilmeldteService.CreateTilmeldte(OpretTilmeldte, eventId);

            return RedirectToPage("/EventCRUD/Index");
        }
        public IActionResult OnPostBekræft(int eventId)
        {
            _tilmeldteService.CreateTilmeldte(OpretTilmeldte, eventId);
            return RedirectToPage("/EventCRUD/Index");
        }
    }
}
