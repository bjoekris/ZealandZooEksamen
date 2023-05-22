using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    public class KalenderModel : PageModel
    {
        private IEventService _kalenderService;
        public KalenderModel(IEventService kalenderService)
        {
            _kalenderService = kalenderService;
        }
        public List<Event> Events { get; set; }
        public void OnGet()
        {
            Events = _kalenderService.GetAllEvents();
        }
        public IActionResult OnPost(int dag)
        {
            string kalenderDag = HentDag(dag);
            Events = _kalenderService.GetAllEvents();
            Event? ev = Events.Find(e => e.Dato == kalenderDag);

            if (ev is null)
            {
                return Page();
            }

            return RedirectToPage("KalenderEvent", new { eventId = ev.EventId });
        }
        public bool HasEvent(int dag)
        {
            string kalenderDag = HentDag(dag);

            return Events.Any(e => e.Dato == kalenderDag);
        }

        private static string HentDag(int dag)
        {
            string kalenderDag = "";
            if (dag < 10)
            {
                kalenderDag = "2023-06-0" + dag;
            }
            else
            {
                kalenderDag = "2023-06-" + dag;
            }

            return kalenderDag;
        }
    }
}
