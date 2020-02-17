using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class UserViewModel
    {
        private readonly User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }
    }
}