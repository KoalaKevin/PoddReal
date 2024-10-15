using System.Reflection;
using System.ServiceModel.Syndication;
using System.Xml;

namespace BL
{
    public class PoddHanterare
    {
        public void GetRss(String rssLink)
        {
            XmlReader reader = XmlReader.Create("https://api.sr.se/api/rss/pod/itunes/3966");
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            List<Models.Podd> poddar = new List<Models.Podd>();
            foreach (SyndicationItem item in feed.Items)
            {
                Models.Podd enPodd = new Models.Podd();
                enPodd.Url = item.Id.ToString();
                enPodd.Name = item.Title.Text;
                poddar.Add(enPodd);
                Models.Podd utPodd = poddar[0];
                

            }
        }
    }
}
