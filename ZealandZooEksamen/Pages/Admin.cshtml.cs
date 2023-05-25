using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.UserStory_12;

namespace ZealandZooEksamen.Pages
{
    public class AdminModel : PageModel
    {
        //Services til siden
        private IEventService _service;
        private IPersonService _personService;
        private ITilmeldteService _tilmeldteService;
        private INyhedsbrevService _brevService;
        public AdminModel(IEventService service, IPersonService personService, ITilmeldteService tilmeldteService, INyhedsbrevService nyhedsbrevService)
        {
            _service = service;
            _brevService = nyhedsbrevService;
            _personService = personService;
            _tilmeldteService = tilmeldteService;
        }
        //Diverse lister
        //public List<Event> MockEvents { get; set; }
        public List<Event> Events { get; set; }
        public List<Person> Personer { get; set; }
        public List<Tilmeldte> Tilmeldte { get; set; }
        public List<Nyhedsbrev> Nyhedsbrevet { get; set; }

        public void OnGet(int? eventId)
        {
            if (eventId is null)
            {

                //Events
                /*MockEvents = _service.GetAllMockEvents()*/

                Events = _service.GetAllEvents();

                ////Tilmelding
                Personer = _personService.GetAllPerson();

                //Tilmelding
                Tilmeldte = _tilmeldteService.GetAllTilmeldte();

                //Nyhedsbrev
                Nyhedsbrevet = _brevService.GetAllNyhedsbrev();
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
                Nyhedsbrevet = _brevService.GetAllNyhedsbrev();
            }
        }
        public double Tæler(int eventId)
        {
            double Tæler = _tilmeldteService.CountTilmeldinger(eventId);
            return Tæler;
        }


        //Nyhedsbrev database

     
    

       
     


    }
}
