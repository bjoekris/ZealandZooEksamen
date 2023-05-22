using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

//User story 15 - Bjørn

namespace ZealandZooEksamen.Pages.EventCRUD
{
    public class EditEventModel : PageModel
    {
        private IEventService _Service;

        public EditEventModel(IEventService service)
        {
            _Service = service;
        }

        [BindProperty]
        public int EventId { get;}

        [BindProperty]
        public string Navn { get; set; } 

        [BindProperty]
        public string EventInfo { get; set; }

        [BindProperty]
        public string Dato { get; set; }

        [BindProperty]
        public string TimeStart { get; set; }

        [BindProperty]
        public string TimeEnd { get; set; }

        [BindProperty]
        public double MaksDeltagere { get; set; }

        [BindProperty]
        public double AntalDeltagere { get; }

        public void OnGet(int eventId)
        {
            Event editEvent = _Service.FindEvent(eventId);

            Navn = editEvent.Navn;
            EventInfo = editEvent.EventInfo;
            Dato = editEvent.Dato;
            TimeStart = editEvent.TimeStart;
            TimeEnd = editEvent.TimeEnd;
            MaksDeltagere = editEvent.MaksDeltagere;
        }

        public IActionResult OnPostEdit(int eventId)
        {
            Event editEvent = _Service.FindEvent(eventId);

            editEvent.Navn = Navn;
            editEvent.EventInfo = EventInfo;
            editEvent.Dato = Dato;
            editEvent.TimeStart = TimeStart;
            editEvent.TimeEnd = TimeEnd;   
            editEvent.MaksDeltagere= MaksDeltagere;

            _Service.EditEvent(eventId, editEvent);

            return RedirectToPage("Index");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("Index");
        }
    }
}







