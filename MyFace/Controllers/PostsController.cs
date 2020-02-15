using Microsoft.AspNetCore.Mvc;
using MyFace.Models;
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
        public IActionResult Posts()
        {
            var posts = _posts.GetAll();
            var viewModel = new PostsViewModel(posts);
            return View(viewModel);
        }
    }
}