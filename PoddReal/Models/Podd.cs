namespace Models
{
    public class Podd
    {
        public string Url { get; set; }
        public string Titel { get; set; }
        public string Namn { get; set; }
        public string Kategori { get; set; } // Ska bli public Kategori Kategori



        public Podd() { }

        public Podd(string url, string titel, string namn, string kategori)
        {
            Url = url;
            Titel = titel;
            Namn = namn;
            Kategori = kategori;
        }

    }
}
