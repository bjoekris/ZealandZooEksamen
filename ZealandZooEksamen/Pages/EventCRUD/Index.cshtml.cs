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

      


        public void OnGet()
        {

            //Events
            /*MockEvents = _service.GetAllMockEvents()*/;
            Events = _service.GetAllEvents();

         
        }


       
   
       


    }
}