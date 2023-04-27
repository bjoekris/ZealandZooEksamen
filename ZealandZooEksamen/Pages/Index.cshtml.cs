using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Pages
{
    public class IndexModel : PageModel
    {
        private IEventService _service;
        public IndexModel(IEventService service)
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