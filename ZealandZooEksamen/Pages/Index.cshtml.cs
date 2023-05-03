﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;
using ZealandZooEksamen.Model;

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
        public IActionResult OnGet()
        {
            Events = _service.GetAllEvents();
            _userservice = SessionHelper.GetUser(HttpContext);
            if (!_userservice.IsLoggedIn)
            {
                return RedirectToPage("Login");
            }

            return Page();
        }

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