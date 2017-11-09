namespace PodcastReader.Models.Podcasts
{
    public class Podcast : IPodcast
    {
        public string Title { get; set ; }
        public string Url { get; set; }
    }
}