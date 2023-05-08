using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Userstory_12;
using ZealandZooEksamen.UserStory_12;

namespace ZealandZooEksamen.Pages
{
    public class UserStory12Model : PageModel
    {

        private IPersonService _personService;
        [BindProperty]
        public Person OpretPerson { get; set; }

      

        public IActionResult OnPostOpret()
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
