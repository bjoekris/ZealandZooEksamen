using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Pages
{
    public class IndexModel : PageModel
    {
        private IEventService _eventService;
        public IndexModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        public List<Event> Events { get; set; }
        public void OnGet()
        {
            Events = _eventService.GetAllEvents();
        }
    }
}