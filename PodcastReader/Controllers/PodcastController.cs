using PodcastReader.Repository.Podcasts;
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
            var podCasts = _podcastRepository.GetPodcasts();

            return View(podCasts);
        }
    }
}