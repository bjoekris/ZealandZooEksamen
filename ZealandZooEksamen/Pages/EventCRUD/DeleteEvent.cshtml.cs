using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.EventCRUD
{
    public class DeleteEventModel : PageModel
    {
        private IEventService _service;

        //[BindProperty]
        public Event SletEvent { get; set; }

        public DeleteEventModel(IEventService service)
        {
            _service = service;
        }
        public void OnGet(int eventId)
        {
            SletEvent = _service.FindEvent(eventId);
        }
        public IActionResult OnPostSlet(int eventId)
        {
            _service.DeleteEvent(eventId);

            return RedirectToPage("Index");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("Index");
        }
    }
}
