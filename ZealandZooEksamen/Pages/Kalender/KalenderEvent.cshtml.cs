using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    public class KalenderEventModel : PageModel
    {
        private IEventService _service;

        [BindProperty]
        public Event SeEvent { get; set; }

        public KalenderEventModel(IEventService service)
        {
            _service = service;
        }
        public void OnGet(int eventId)
        {
            SeEvent = _service.FindEvent(eventId);
        }
        public IActionResult OnPostTilbage()
        {
            return RedirectToPage("EventCRUD/Index");
        }
    }
}
