using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.EventCRUD
{
    public class CreateEventModel : PageModel
    {
        private IEventService _eventService;

        [BindProperty]
        public Event OpretEvent { get; set; }

        public CreateEventModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        public void OnGet(int eventId)
        {
            OpretEvent = _eventService.FindEvent(eventId);
        }
        public IActionResult OnPostOpret(int eventId)
        {
            _eventService.CreateEvent(eventId);

            return RedirectToPage("~\\Pages\\Index.cshtml");
        }
        public IActionResult OnPostBekræft()
        {
            return RedirectToPage("~\\Pages\\Index.cshtml");
        }
    }
}
