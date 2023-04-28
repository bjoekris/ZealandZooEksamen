using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.MockData;

namespace ZealandZooEksamen.Pages.EventCRUD
{
    public class IndexModel : PageModel
    {
        private IEventService _service;
        public IndexModel(IEventService service)
        {
            _service = service;
        }
        public List<Event> MockEvents { get; set; }
        //public List<Event> Events { get; set; }
        public void OnGet()
        {
            MockEvents = _service.GetAllMockEvents();
            //Events = _service.GetAllEvents();
        }
    }
}