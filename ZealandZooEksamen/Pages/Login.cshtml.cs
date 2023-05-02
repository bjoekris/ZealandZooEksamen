using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _service;

        public LoginModel(IUserService service)
        {
            _service = service;
        }




        [BindProperty]
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Der skal være et navn")]
        public String Name { get; set; }

        [BindProperty]
        [Required]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Password skal være mere end 6 tegn")]
        public String Password1 { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Name == "admin" && Password1 == "secret")
            {
                _service.SetUserLoggedIn(Name, true);
            }
            else
            {
                _service.SetUserLoggedIn(Name, false);
            }

            return RedirectToPage("Index");
        }
    }
}
