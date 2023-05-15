using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    //Kader
    public class LogoutModel : PageModel
    {
        private IUserService _userservice;

        public LogoutModel()
        {

        }

        public IActionResult OnGet()
        {
            _userservice = SessionHelper.GetUser(HttpContext);
            _userservice.UserLoggedOut();
            SessionHelper.SetUser(_userservice, HttpContext);

            return RedirectToPage("Index");
        }
    }
}
