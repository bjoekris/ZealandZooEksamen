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
        public List<Event> Events { get; set; }
        public IActionResult OnGet()
        {
            Events = _service.GetAllEvents();
            Personer = _personService.GetAllPerson();
        }

        //Tilmeldingsting
        private IPersonService _personService;
        public IndexModel(IPersonService personService)
        {
            _personService = personService;
            _userservice = SessionHelper.GetUser(HttpContext);
            if (!_userservice.IsLoggedIn)
            {
                return RedirectToPage("Login");
            }

            return Page();
        }

        public List<Person> Personer { get; set; }

      

        //login
        private IUserService _userservice;

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