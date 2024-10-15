using System.Diagnostics;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Xml;

namespace BL
{
    public class PoddHanterare
    {
        private String? utPoddText;
        public String GetRss(String rssLink)
        {
            Debug.WriteLine("Då");
            XmlReader reader = XmlReader.Create("https://feed.pod.space/alexosigge");
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            List<Models.Podd> poddar = new List<Models.Podd>();

            foreach (SyndicationItem item in feed.Items)
            {
                Models.Podd enPodd = new Models.Podd();
                enPodd.Url = item.Id.ToString();
                enPodd.Name = item.Title.Text;
                poddar.Add(enPodd);
                Models.Podd utPodd = poddar[0];
                utPoddText = utPodd.Name;
                

            }
            return utPoddText;
        }
    }
}
