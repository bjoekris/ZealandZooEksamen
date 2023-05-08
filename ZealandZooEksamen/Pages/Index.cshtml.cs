using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Userstory_12;
namespace ZealandZooEksamen.Pages
{
    public class IndexModel : PageModel
    {
      private IPersonService _personService;
        public IndexModel(IPersonService personService)
        {
            _personService = personService;
        }

        public List<PersonListe> Personer { get; set; }

        public void OnGet()
        {
            Personer = _personService.GetAllPerson();
        }
    }
}