using AutoMapper;
using PodcastReader.Models.Podcasts;

namespace PodcastReader
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Podcast, PodcastModel>();
            });
        }
    }
}