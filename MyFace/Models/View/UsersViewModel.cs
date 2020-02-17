using System.Collections.Generic;
using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class UsersViewModel
    {
        private IEnumerable<User> _users;

        public UsersViewModel(IEnumerable<User> users)
        {
            _users = users;
        }
    }
}