using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandZooEksamen.Model;
using ZealandZooEksamen.Services;

namespace ZealandZooEksamen.Pages.TilmeldingCRUD
{
    public class TilmeldingIndexModel : PageModel
    {
        //public void OnGet()
        //{
        //}


        private INyhedsbrevService _service;
        public TilmeldingIndexModel(INyhedsbrevService nyhedsbrevService)
        {
            _service = nyhedsbrevService;
        }

        public List<Nyhedsbrev> Nyhedsbrevet { get; set; }
        public void OnGet()
        {


            Nyhedsbrevet = _service.GetAllNyhedsbrev();
        }

    }
}
