using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages
{
    public class TilmeldingModel : PageModel
    {
        private IEventService eventService;

        public TilmeldingModel(IEventService eventService)
        {
            this.eventService = eventService;
        }

        public void OnGet()
        {

        }
    }
}
