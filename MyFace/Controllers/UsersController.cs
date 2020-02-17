using Microsoft.AspNetCore.Mvc;
using MyFace.Models.Request;
using MyFace.Models.View;
using MyFace.Repositories;

namespace MyFace.Controllers
{
    [Route("/users")]
    public class UsersController : Controller
    {
        private readonly IUsersRepo _users;

        public UsersController(IUsersRepo users)
        {
            _users = users;
        }
        
        [HttpGet("")]
        public IActionResult UsersPage()
        {
            var users = _users.GetAll();
            var viewModel = new UsersViewModel(users);
            return View(viewModel);
        }

        [HttpGet("{id}")]
        public IActionResult UserPage(int id)
        {
            var user = _users.GetById(id);
            var viewModel = new UserViewModel(user);
            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult CreateUserPage()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(CreateUserRequestModel newUser)
        {
            _users.Create(newUser);
            return RedirectToAction("UserPage");
        }
    }
}