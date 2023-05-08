using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Userstory_12;
using ZealandZooEksamen.UserStory_12;

namespace ZealandZooEksamen.Pages
{
    public class UserStory12Model : PageModel
    {

        private readonly IPersonService? _personService;
        [BindProperty]
        public Person OpretPerson { get; set; }

        public IPersonService? Get_personService()
        {
            return _personService;
        }

        public IActionResult OnPostOpret(IPersonService? _personService)
        {
            _personService.CreatePerson(OpretPerson);
            return RedirectToPage("UserStory12");
        }

        public List<PersonListe> Personer { get; set; }
        public void OnGet()
        {
        }
    }
}
