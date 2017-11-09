using PodcastReader.Models.Podcasts;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Collections.ObjectModel;

namespace PodcastReader.Repository.Podcasts
{
    public class PodcastRepository : IPodcastRepository
    {
        public IEnumerable<Podcast> GetPodcastsFromXml(string xml)
        {
            string url = "https://www.dr.dk/mu/Feed/p1-debat.xml?format=podcast&limit=500";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            var podcasts = new List<Podcast>();

            foreach (SyndicationItem item in feed.Items)
            {
                podcasts.Add(new Podcast { Title = item.Title.Text, Url = GetFirstLinkUriString(item.Links) });
            }

            return podcasts;
        }

        private string GetFirstLinkUriString(Collection<SyndicationLink> links)
        {
            if (links.Any())
            {
                return links[0].Uri.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}