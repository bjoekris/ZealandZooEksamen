using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZealandZooEksamen.Pages
{
    public class KalenderNoEventModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostTilbage()
        {
            return RedirectToPage("EventCRUD/Index");
        }
    }
}
