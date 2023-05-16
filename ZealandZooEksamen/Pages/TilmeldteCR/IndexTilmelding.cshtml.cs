using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Pages.TilmeldteCR
{
    public class IndexTilmeldingModel : PageModel
    {
        public List<Tilmeldte> Tilmeldte { get; set; }
        public void OnGet()
        {

        }
    }
}
