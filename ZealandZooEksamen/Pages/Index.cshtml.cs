using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Userstory_12;
using ZealandZooEksamen.UserStory_12;
using Microsoft.AspNetCore.Mvc;

namespace ZealandZooEksamen.Pages
{
    public class IndexModel : PageModel
    {
        private IEventService _service;
        private IPersonService _personService;
        private IUserService _userservice;



        public IndexModel(IEventService service, IPersonService personService)
        {
            _service = service;

            _personService = personService;


           

        }
        public List<Event> Events { get; set; }
        public List<Person> Personer { get; set; }


        public IActionResult OnGet()
        {
            Events = _service.GetAllEvents();
            Personer = _personService.GetAllPerson();

            _userservice = SessionHelper.GetUser(HttpContext);
            if (!_userservice.IsLoggedIn)
            {
                return RedirectToPage("Login");
            }

            return Page();
        }

      
        //login
        

        public bool IsAdmin
        {
            get
            {
                return _userservice.IsUserAdmin;
            }
        }

        public String Name => _userservice.UserName;
    }
}