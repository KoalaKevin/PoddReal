using System.Diagnostics;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Xml;
using DL;
using Models;

namespace BL
{
    public class PoddHanterare
    {
       

        private IPoddRepository<Podd> repository;
        private String? utPoddText;

        public PoddHanterare() { 
            repository = new Repository();       
        }

        public List<Avsnitt> AllaAvsnitt(String link)
        {
            List<Avsnitt> lista = new List<Avsnitt>(); // Ska kanske vara i Dl men man sparar inget?
            XmlReader reader = XmlReader.Create(link);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach (SyndicationItem item in feed.Items)
            {
                Avsnitt ettAvsnitt = new Avsnitt();
                ettAvsnitt.Namn = item.Title.Text;
                ettAvsnitt.Beskrivning = item.Summary.Text;
                lista.Add(ettAvsnitt);

            }
            Debug.WriteLine(lista);
            return lista;
        }
        public List<Podd> GetPoddByKategori(String kategori)
        {
            List<Podd> lista = repository.HamtaAlla(); // Vi kanske ska ladda in poddarna in i en lista i början av programmet och sen bara hämta från listan, mer optimerat
            List<Podd> utLista = new List<Podd>();  
            var fraga = from enPodd in lista
                        where enPodd.Kategori.Equals(kategori)
                        select enPodd;
            foreach (var enPodd in fraga)
            {
                utLista.Add(enPodd);
            }

            return utLista;
        }
        public String GetRss(String rssLink) //Flytta till DL?
        {
            try
            {
                XmlReader reader = XmlReader.Create(rssLink);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
            


            foreach (SyndicationItem item in feed.Items)
            {
                Podd enPodd = new Podd();
                enPodd.Url = item.Id.ToString();
                enPodd.Namn = item.Title.Text;
                repository.Skapa(enPodd);
                List<Podd> test = repository.HamtaAlla();
                Podd utPodd = test[0];
                utPoddText = utPodd.Namn;
                

            }
            }
            catch (Exception ex) { }

            return utPoddText;
        }

        public string HamtaTitel(string url)
        {
            try
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                return feed.Title.Text;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Kunde inte hämta titeln");
                Debug.WriteLine(ex.Message);
                return string.Empty;
            }
            
        }

        public Podd HamtaPodd(string titel)
        {
            return repository.HamtaMedTitel(titel);
        }

        public int HamtaIndexMedUrl(string url)
        {
           return repository.HamtaIndex(url);
        }


        public void SkapaPodd(string url, string titel, string namn, string kategori)
        {
            Podd nyPodd = new Podd(url, titel, namn, kategori);
                repository.Skapa(nyPodd);   
        }

        public void RaderaPodd(string url)
        {
            int index = repository.HamtaIndex(url);
            repository.Radera(index);
        }

        public void RedigeraPodd(int index, Podd podd)
        {
            if (index >= 0 && index < HamtaPoddar().Count && podd != null)
            {  
                repository.Uppdatera(index, podd);
            }
            else
            {
                Debug.WriteLine("Felaktigt index eller Podd!");
            }
        }

        public List<Podd> HamtaPoddar()
        {
            return repository.HamtaAlla();
        }


    }
}
