using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    public class KalenderEventModel : PageModel
    {
        private IEventService _service;
        private ITilmeldteService _tilmeldteService;

        [BindProperty]
        public Event SeEvent { get; set; }

        public List<Event> Events { get; set; }
        public List<Tilmeldte> Tilmeldte { get; set; }

        public KalenderEventModel(IEventService service, ITilmeldteService tilmeldteService)
        {
            _service = service;
            _tilmeldteService = tilmeldteService;
        }
        public void OnGet(int eventId)
        {
            SeEvent = _service.FindEvent(eventId);
        }
        public IActionResult OnPostTilbage()
        {
            return RedirectToPage("EventCRUD/Index");
        }
        public double Tæler(int eventId)
        {
            double Tæler = _tilmeldteService.CountTilmeldinger(eventId);
            return Tæler;
        }
    }
}
