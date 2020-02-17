using Microsoft.AspNetCore.Mvc;
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
        
        public IActionResult UsersPage()
        {
            var users = _users.GetAll();
            var viewModel = new UsersViewModel(users);
            return View(viewModel);
        }
    }
}