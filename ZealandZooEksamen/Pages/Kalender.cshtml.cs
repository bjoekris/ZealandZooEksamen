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
    }
}
