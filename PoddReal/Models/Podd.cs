namespace Models
{
    public class Podd
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Kategori { get; set; } // Ska bli public Kategori Kategori

        public Podd() { }

        public Podd(String url, String name, string kategori)
        {
            Url = url;
            Name = name;
            Kategori = kategori;
        }

    }
}
