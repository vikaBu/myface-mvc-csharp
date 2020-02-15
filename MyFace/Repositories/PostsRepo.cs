using System.Collections.Generic;
using MyFace.Models.Database;

namespace MyFace.Repositories
{
    public interface IPostsRepo
    {
        IEnumerable<Post> GetAll();
    }
    
    public class PostsRepo : IPostsRepo
    {
        private readonly MyFaceDbContext _context;

        public PostsRepo(MyFaceDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Post> GetAll()
        {
            return _context.Posts;
        }
    }
}