using Microsoft.AspNetCore.Mvc;

namespace MyFace.Controllers
{
    [Route("/posts")]
    public class PostsController : Controller
    {
        [HttpGet("")]
        public IActionResult Posts()
        {
            return View();
        }
    }
}