using System.Collections.Generic;
using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class PostsViewModel
    {
        private IEnumerable<Post> _posts;

        public PostsViewModel(IEnumerable<Post> posts)
        {
            _posts = posts;
        }
    }
}