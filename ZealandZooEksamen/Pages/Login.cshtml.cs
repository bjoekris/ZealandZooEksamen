using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    //Kader
    public class LoginModel : PageModel
    {
        private IUserService _userservice;

        public LoginModel()
        {

        }




        [BindProperty]
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Der skal være et navn")]
        public String Name { get; set; }

        [BindProperty]
        [Required]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Password skal være mere end 6 tegn")]
        public String Password1 { get; set; }


        public void OnGet()
        {
            _userservice = SessionHelper.GetUser(HttpContext);
        }

        public IActionResult OnPost()
        {
            _userservice = SessionHelper.GetUser(HttpContext);

            if (!ModelState.IsValid)
            {
                return Page();
            }


            if (Name == "admin" && Password1 == "mmbk23")
            {
                _userservice.SetUserLoggedIn(Name, true);
            }
            else
            {
                _userservice.SetUserLoggedIn(Name, false);
            }


            SessionHelper.SetUser(_userservice, HttpContext);
            return RedirectToPage("Homepage");
        }
    }
}
