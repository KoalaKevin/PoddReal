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
        public PoddHanterare() { 
            repository = new Repository();
            
        }
        private String? utPoddText;
        public List<Podd> getAllPodd()
        {
            return repository.GetAllPodds();
        }
        public String GetRss(String rssLink)
        {
            try
            {
                XmlReader reader = XmlReader.Create(rssLink);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
            


            foreach (SyndicationItem item in feed.Items)
            {
                Podd enPodd = new Podd();
                enPodd.Url = item.Id.ToString();
                enPodd.Name = item.Title.Text;
                repository.AddPodd(enPodd);
                List<Podd> test = repository.GetAllPodds();
                Podd utPodd = test[0];
                utPoddText = utPodd.Name;
                

            }
            }
            catch (Exception ex) { }

            return utPoddText;
        }
    }
}
