namespace Models
{
    public class Podd
    {
        
            public String? Url { get; set; }
            public String? Name { get; set; }

            public Podd() { }

            public Podd(String url, String name)
            {
                Url = url;
                Name = name;
            }
        
    }
}
