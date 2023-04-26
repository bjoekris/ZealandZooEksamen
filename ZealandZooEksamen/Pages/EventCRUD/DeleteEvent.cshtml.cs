using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.EventCRUD
{
    public class DeleteEventModel : PageModel
    {
        private IEventService _eventService;

        [BindProperty]
        public Event SletEvent { get; set; }

        public DeleteEventModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        public void OnGet(int eventId)
        {
            SletEvent = _eventService.FindEvent(eventId);
        }
        public IActionResult OnPostSlet(int eventId)
        {
            _eventService.DeleteEvent(eventId);

            return RedirectToPage("~\\Pages\\Index.cshtml");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("~\\Pages\\Index.cshtml");
        }
    }
}
