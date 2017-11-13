using NUnit.Framework;
using PodcastReader.Controllers;
using PodcastReader.Repository.Podcasts;
using System.Web.Mvc;

namespace PodcastReader.Tests.Controllers
{
    [TestFixture]
    public class PodcastControllerTest
    {
        [SetUp]
        public void Init()
        {
            AutoMapperConfiguration.Configure();
        }

        [Test]
        public void IndexTest()
        {
            PodcastController controller = new PodcastController(new PodcastRepository());
            
            ViewResult result = controller.Index() as ViewResult;
            
            Assert.IsNull(result);
        }
    }
}
