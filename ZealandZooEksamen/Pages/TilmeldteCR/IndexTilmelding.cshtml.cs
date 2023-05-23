using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.TilmeldteCR
{
    public class IndexTilmeldingModel : PageModel
    {
        private ITilmeldteService _tilmeldteService;
        public IndexTilmeldingModel(ITilmeldteService tilmeldteService)
        {

            _tilmeldteService = tilmeldteService;
        }
        public List<Tilmeldte> Tilmeldte { get; set; }

        public void OnGet(int TilmeldingId)
        {
            Tilmeldte = _tilmeldteService.GetAllTilmeldte();
        }
    }
}
