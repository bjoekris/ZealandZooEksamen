using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

//User story 10 - Bjørn

namespace ZealandZooEksamen.Pages.LagerCRUD
{
    public class DeleteLagerModel : PageModel
    {
        //public void OnGet()
        //{
        //}

     
        private ILagerService _service;

        [BindProperty]
        public Lager SletLager { get; set; }
        
        public DeleteLagerModel(ILagerService service)
        {
            _service = service;
        }
        public void OnGet(int lagerId)
        {
            //SletMockEvent = _service.FindMockEvent(eventId);
            SletLager = _service.FindLager(lagerId);
        }
        public IActionResult OnPostSlet(int lagerId)
        {
            //_service.DeleteMockEvent(eventId);
            _service.DeleteLager(lagerId);

            return RedirectToPage("IndexLager");
        }
        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("IndexLager");
        }
    }
}
