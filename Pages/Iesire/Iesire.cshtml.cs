using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect_CioranuSorinGeorge.Date;
using Proiect_CioranuSorinGeorge.Models;

namespace Proiect_CioranuSorinGeorge.Pages.Iesire
{
    [BindProperties(SupportsGet = true)]
    public class IesireModel : PageModel
    {
        
        public string NumeBurger { get; set; }
        public float BurgerPret { get; set; }
        public string ImageTitle { get; set; }

        private readonly AplicatieDbContact _context;
        public IesireModel(AplicatieDbContact context)
        {
            _context = context;
        }


        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(NumeBurger))
            {
                NumeBurger = "Custom";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            Comenzi comenzi = new Comenzi();
            comenzi.NumeBurger = NumeBurger;
            comenzi.Pret = BurgerPret;

            _context.Comenzi.Add(comenzi);
            _context.SaveChanges();


        }
    }
}
