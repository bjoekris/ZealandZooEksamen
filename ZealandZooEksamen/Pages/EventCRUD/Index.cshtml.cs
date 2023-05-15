using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.MockData;
using ZealandZooEksamen.UserStory_12;

namespace ZealandZooEksamen.Pages.EventCRUD
{
    //Bj�rn

    public class IndexModel : PageModel
    {
       //Services til Index
        private IEventService _service;
     





        public IndexModel(IEventService service)
        {
            _service = service;
           
        }

        //Diverse lister
        //public List<Event> MockEvents { get; set; }
        public List<Event> Events { get; set; }

      

        public void OnGet(int? eventId)
        {
            if (eventId is null) { 

            //Events
            /*MockEvents = _service.GetAllMockEvents()*/;
            Events = _service.GetAllEvents();

            //Tilmelding
            Personer = _personService.GetAllPerson();
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
            }
        }

        public void OnPost(int eventId)
        {
            
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