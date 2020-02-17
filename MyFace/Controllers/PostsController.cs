using Microsoft.AspNetCore.Mvc;
using MyFace.Models.Request;
using MyFace.Models.View;
using MyFace.Repositories;

namespace MyFace.Controllers
{
    [Route("/posts")]
    public class PostsController : Controller
    {
        private readonly IPostsRepo _posts;

        public PostsController(IPostsRepo posts)
        {
            _posts = posts;
        }
        
        [HttpGet("")]
        public IActionResult PostsPage()
        {
            var posts = _posts.GetAll();
            var viewModel = new PostsViewModel(posts);
            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult CreatePostPage()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost(CreatePostRequestModel postModel)
        {
            _posts.CreatePost(postModel);
            return RedirectToAction("PostsPage");
        }
    }
}