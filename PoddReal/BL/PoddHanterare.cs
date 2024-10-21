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
       

        private Repository repository;
        private SerializeHelper<Podd> serializeHelper;

        public PoddHanterare() { 
            repository = new Repository();
            serializeHelper = new SerializeHelper<Podd>();
            repository.fyllLista(serializeHelper.laddaIn(@"..\..\poddList.xml"));
            
        }
        private String? utPoddText;
        public List<Podd> getAllPodd()
        {
            return repository.GetAllPodds();
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
                repository.AddPodd(enPodd);
                List<Podd> test = repository.GetAllPodds();
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
                Console.WriteLine("Kunde inte hämta titeln");
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
            
        }

        public void SkapaPodd(string url, string titel, string namn, string kategori)
        {
            Podd nyPodd = new Podd(url, titel, namn, kategori);
                repository.AddPodd(nyPodd);   
        }

        public List<Podd> HamtaPoddar()
        {
            return repository.GetAllPodds();
        }


    }
}
