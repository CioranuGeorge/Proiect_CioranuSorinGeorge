using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect_CioranuSorinGeorge.Date;
using Proiect_CioranuSorinGeorge.Models;

namespace Proiect_CioranuSorinGeorge.Pages
{
    public class ComenziModel : PageModel
    {

        public List<Comenzi> Comenzi = new List<Comenzi>();

        private readonly AplicatieDbContact _context;

        public ComenziModel(AplicatieDbContact context)
        {
            _context = context;
        }


        public void OnGet()
        {
            Comenzi = _context.Comenzi.ToList();
        }
    }
}
