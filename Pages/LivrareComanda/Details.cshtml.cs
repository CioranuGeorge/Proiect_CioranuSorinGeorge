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
    public class DetailsModel : PageModel
    {
        private readonly Proiect_CioranuSorinGeorge.Date.AplicatieDbContact _context;

        public DetailsModel(Proiect_CioranuSorinGeorge.Date.AplicatieDbContact context)
        {
            _context = context;
        }

      public Livrare Livrare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Livrare == null)
            {
                return NotFound();
            }

            var livrare = await _context.Livrare.FirstOrDefaultAsync(m => m.ID == id);
            if (livrare == null)
            {
                return NotFound();
            }
            else 
            {
                Livrare = livrare;
            }
            return Page();
        }
    }
}
