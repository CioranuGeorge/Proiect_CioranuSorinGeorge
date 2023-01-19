using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_CioranuSorinGeorge.Date;
using Proiect_CioranuSorinGeorge.Models;

namespace Proiect_CioranuSorinGeorge.Pages.LivrareComanda
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_CioranuSorinGeorge.Date.AplicatieDbContact _context;

        public CreateModel(Proiect_CioranuSorinGeorge.Date.AplicatieDbContact context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Livrare Livrare { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Livrare.Add(Livrare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
