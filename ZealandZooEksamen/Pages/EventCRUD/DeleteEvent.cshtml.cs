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
        private ITilmeldteService _tilmeldteService;

        [BindProperty]
        public Event SletEvent { get; set; }
        
        [BindProperty]
        public Event SletMockEvent { get; set; }

        public List<Tilmeldte> Tilmeldte { get; set; }

        public DeleteEventModel(IEventService service, ITilmeldteService tilmeldteService)
        {
            _service = service;
            _tilmeldteService = tilmeldteService;
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
        public double Tæler(int eventId)
        {
            double Tæler = _tilmeldteService.CountTilmeldinger(eventId);
            return Tæler;
        }
    }
}
