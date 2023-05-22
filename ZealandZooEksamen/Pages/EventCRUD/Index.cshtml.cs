using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.MockData;
using ZealandZooEksamen.UserStory_12;
using ZealandZooEksamen.Pages.TilmeldteCR;


namespace ZealandZooEksamen.Pages.EventCRUD
{
    //Bjørn

    public class IndexModel : PageModel
    {
        //Services til Index
        private IEventService _service;
        private IPersonService _personService;
        private ITilmeldteService _tilmeldteService;




        public IndexModel(IEventService service, IPersonService personService, ITilmeldteService tilmeldteService)
        {
            _service = service;
            _personService = personService;
            _tilmeldteService = tilmeldteService;
        }

        //Diverse lister
        //public List<Event> MockEvents { get; set; }
        public List<Event> Events { get; set; }
        public List<Person> Personer { get; set; }

        public List <Tilmeldte> Tilmeldte { get; set; }



        public void OnGet(int? eventId)
        {
            if (eventId is null)
            {

                //Events
                /*MockEvents = _service.GetAllMockEvents()*/
                
                Events = _service.GetAllEvents();

                //Login
                Personer = _personService.GetAllPerson();

                //Tilmelding
                Tilmeldte = _tilmeldteService.GetAllTilmeldte();
            }
            else
            {
                IUserService user = SessionHelper.GetUser(HttpContext);
                Event ev = _service.FindEvent((int)eventId);
                if (!ev.Tilmeldte.Contains(user.UserName))
                {
                    ev.Tilmeldte.Add(user.UserName);
                }
                Events = _service.GetAllEvents();
                Personer = _personService.GetAllPerson();
                Tilmeldte = _tilmeldteService.GetAllTilmeldte();
            }
        }




        public double LedigePladser(int eventId)
        {

            var events = Events.Where(s => s.EventId == eventId);

            double sum = 0;
            foreach (var e in events)
            {
                sum += e.MaksDeltagere - e.AntalDeltagere;
            }

            return sum;
        }
    }

        
}

