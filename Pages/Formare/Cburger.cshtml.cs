using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect_CioranuSorinGeorge.Models;

namespace Proiect_CioranuSorinGeorge.Pages.Formare
{
    public class CburgerModel : PageModel
    {
        [BindProperty]
        public BurgersModel Burger { get; set; }
        public float BurgerPret { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            BurgerPret = Burger.Pret;

            if (Burger.Ceapa) BurgerPret +=4;
            if (Burger.Cascaval) BurgerPret +=7;
            if (Burger.Castraveti) BurgerPret +=4;
            if (Burger.Masline) BurgerPret +=4;
            if (Burger.Ardei) BurgerPret +=3;
            if (Burger.Carnevita) BurgerPret +=10;
            if (Burger.Rosii) BurgerPret +=5;


            return RedirectToPage("/Iesire/Iesire", new { Burger.NumeBurger, BurgerPret });
        }

        
      
    }
}
