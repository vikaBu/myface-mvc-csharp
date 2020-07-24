using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class PostsViewModel
    {
        public int CurrentPageNumber { get; }
        public int PostsPerPage { get; }
        public IEnumerable<PostViewModel> Posts { get; }

        public PostsViewModel(IEnumerable<Post> posts, int currentPageNumber, int postsPerPage)
        {
            Posts = posts.Select(post => new PostViewModel(post));
            CurrentPageNumber = currentPageNumber;
            PostsPerPage = postsPerPage;
        }

        public string PreviousPage => $"/posts?pageNumber={CurrentPageNumber - 1}&postsPerPage={PostsPerPage}";
        public string NextPage => $"/posts?pageNumber={CurrentPageNumber + 1}&postsPerPage={PostsPerPage}";
    }
}