using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    public class KalenderModel : PageModel
    {
        private IEventService _service;
        public KalenderModel(IEventService service)
        {
            _service = service;
        }
        public List<Event> Events { get; set; }
        public void OnGet()
        {
            Events = _service.GetAllEvents();
        }
    }
}
