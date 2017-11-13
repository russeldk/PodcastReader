using AutoMapper;
using PodcastReader.Models.Podcasts;
using PodcastReader.Repository.Podcasts;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PodcastReader.Controllers
{
    public class PodcastController : Controller
    {
        private readonly IPodcastRepository _podcastRepository;

        public PodcastController(IPodcastRepository podcastRepository)
        {
            _podcastRepository = podcastRepository;
        }

        // GET: Podcast
        public ActionResult Index()
        {
            var podcasts = _podcastRepository.GetPodcasts();
            var podcastModels = Mapper.Map<IEnumerable<Podcast>, IEnumerable<PodcastModel>>(podcasts);

            return View(podcastModels);
        }
    }
}