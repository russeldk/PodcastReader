using PodcastReader.Models.Podcasts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodcastReader.Repository.Podcasts
{
    public interface IPodcastRepository
    {
        IEnumerable<Podcast> GetPodcasts();
    }
}