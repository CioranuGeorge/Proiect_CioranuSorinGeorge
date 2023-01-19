namespace Proiect_CioranuSorinGeorge.Models
{
    public class BurgersModel
    {
        public string ImageTitle { get; set; }
        public string NumeBurger { get; set; }
        public float Pret { get; set; } = 5;
        public bool Rosii { get; set; }
        public bool Ceapa { get; set; }
        public bool Cascaval { get; set; }
        public bool Carnevita { get; set; }
        public bool Castraveti { get; set; }
        public bool Masline { get; set; }
        public bool Ardei { get; set; }
        public float PretTotal { get; set; }
    }
}
