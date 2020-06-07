using System.Web.Mvc;
using TsBlog.Domain.Entities;
using TsBlog.Services.PostService;
using TsBlog.AutoMappingConfig;

namespace TsBlog.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;

        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Post()
        {
            Post post = _postService.FindById(1);
            var dto = post.ToModel();
            return View(dto);
        }
    }
}