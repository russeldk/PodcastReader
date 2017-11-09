namespace PodcastReader.Models.Podcasts
{
    public interface IPodcast
    {
        string Title { get; set; }
        string Url { get; set; }
    }
}