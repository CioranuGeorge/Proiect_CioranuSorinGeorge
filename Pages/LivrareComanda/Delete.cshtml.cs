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
    public class DeleteModel : PageModel
    {
        private readonly Proiect_CioranuSorinGeorge.Date.AplicatieDbContact _context;

        public DeleteModel(Proiect_CioranuSorinGeorge.Date.AplicatieDbContact context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Livrare == null)
            {
                return NotFound();
            }
            var livrare = await _context.Livrare.FindAsync(id);

            if (livrare != null)
            {
                Livrare = livrare;
                _context.Livrare.Remove(Livrare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
