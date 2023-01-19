using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_CioranuSorinGeorge.Date;
using Proiect_CioranuSorinGeorge.Models;

namespace Proiect_CioranuSorinGeorge.Pages.LivrareComanda
{
    public class EditModel : PageModel
    {
        private readonly Proiect_CioranuSorinGeorge.Date.AplicatieDbContact _context;

        public EditModel(Proiect_CioranuSorinGeorge.Date.AplicatieDbContact context)
        {
            _context = context;
        }

        [BindProperty]
        public Livrare Livrare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Livrare == null)
            {
                return NotFound();
            }

            var livrare =  await _context.Livrare.FirstOrDefaultAsync(m => m.ID == id);
            if (livrare == null)
            {
                return NotFound();
            }
            Livrare = livrare;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Livrare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivrareExists(Livrare.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LivrareExists(int id)
        {
          return _context.Livrare.Any(e => e.ID == id);
        }
    }
}
