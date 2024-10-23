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
        private String? utPoddText;

        public PoddHanterare() { 
            repository = new Repository();
            serializeHelper = new SerializeHelper<Podd>();
            repository.FyllLista(serializeHelper.laddaIn(@"..\..\poddList.xml"));
            
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
                repository.LaggTillPodd(enPodd);
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
                Debug.WriteLine("Kunde inte hämta titeln");
                Debug.WriteLine(ex.Message);
                return string.Empty;
            }
            
        }

        public Podd HamtaPodd(string titel)
        {
            return repository.HamtaMedTitel(titel);
        }

        public void SkapaPodd(string url, string titel, string namn, string kategori)
        {
            Podd nyPodd = new Podd(url, titel, namn, kategori);
                repository.LaggTillPodd(nyPodd);   
        }

        public bool RaderaPodd(string url)
        {
            bool godkandUrl = false;
            foreach (Podd enPodd in HamtaPoddar())
            {
                if (enPodd.Url.Equals(url))
                {
                    repository.TaBortPodd(enPodd);
                    godkandUrl = true;
                    break;
                }
            } 
            return godkandUrl;
        }

        public void RedigeraPodd(int index, Podd podd)
        {
            if (index >= 0 && index < HamtaPoddar().Count && podd != null)
            {  
                repository.RedigeraPodd(index, podd);
            }
            else
            {
                Debug.WriteLine("Felaktigt index eller Podd!");
            }
        }

        public List<Podd> HamtaPoddar()
        {
            return repository.GetAllPodds();
        }


    }
}
