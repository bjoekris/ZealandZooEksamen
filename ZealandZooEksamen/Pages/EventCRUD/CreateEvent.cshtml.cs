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
        
        public IActionResult OnPostOpret()
        {
            _eventService.CreateEvent(OpretEvent);

            return RedirectToPage("Index");
        }
        public IActionResult OnPostBekræft()
        {
            return RedirectToPage("Index");
        }
    }
}
