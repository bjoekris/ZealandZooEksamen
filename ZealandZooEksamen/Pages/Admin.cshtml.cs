using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.UserStory_12;

namespace ZealandZooEksamen.Pages
{
    public class AdminModel : PageModel
    {

        private IPersonService _personService;
        public AdminModel(IPersonService personService)
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
