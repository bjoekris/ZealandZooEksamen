using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Userstory_12;
using ZealandZooEksamen.UserStory_12;

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

        //Tilmeldingsting
        private IPersonService _personService;
        public IndexModel(IPersonService personService)
        {
            _personService = personService;
        }

        public List<Person> Personer { get; set; }

        public void OnGet()
        {
            Personer = _personService.GetAllPerson();
        }
    }
}