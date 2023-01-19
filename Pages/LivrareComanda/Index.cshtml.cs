using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_CioranuSorinGeorge.Date;
using Proiect_CioranuSorinGeorge.Models;

namespace Proiect_CioranuSorinGeorge.Pages.LivrareComanda
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_CioranuSorinGeorge.Date.AplicatieDbContact _context;

        public IndexModel(Proiect_CioranuSorinGeorge.Date.AplicatieDbContact context)
        {
            _context = context;
        }

        public IList<Livrare> Livrare { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Livrare != null)
            {
                Livrare = await _context.Livrare.ToListAsync();
            }
        }
    }
}
