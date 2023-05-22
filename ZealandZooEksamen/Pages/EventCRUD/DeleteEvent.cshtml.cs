using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

//User story 14 - Magnus

namespace ZealandZooEksamen.Pages.EventCRUD
{
    public class DeleteEventModel : PageModel
    {
        private IEventService _service;
        private ITilmeldteService _tilmeldingService;

        [BindProperty]
        public Event SletEvent { get; set; }
        
        [BindProperty]
        public Event SletMockEvent { get; set; }

        public DeleteEventModel(IEventService service, ITilmeldteService tilmeldingService)
        {
            _service = service;
            _tilmeldingService = tilmeldingService;
        }
        public void OnGet(int eventId)
        {
            //SletMockEvent = _service.FindMockEvent(eventId);
            SletEvent = _service.FindEvent(eventId);
        }
        public IActionResult OnPostSlet(int eventId)
        {
            //_service.DeleteMockEvent(eventId);
            _service.DeleteEvent(eventId);

            return RedirectToPage("/Admin");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("/Admin");
        }
    }
}
