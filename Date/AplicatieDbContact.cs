using Microsoft.EntityFrameworkCore;
using Proiect_CioranuSorinGeorge.Models;

namespace Proiect_CioranuSorinGeorge.Date
{
    public class AplicatieDbContact : DbContext
    {
        public DbSet<Comenzi> Comenzi { get; set; }

        public AplicatieDbContact(DbContextOptions<AplicatieDbContact> options) 
            : base(options)
        {

        }

        public DbSet<Proiect_CioranuSorinGeorge.Models.Livrare> Livrare { get; set; }
    }
}
