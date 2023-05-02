using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    public class LogoutModel : PageModel
    {
        private IUserService _service;

        public LogoutModel(IUserService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            _service.UserLoggedOut();
            return RedirectToPage("Index");
        }
    }
}
