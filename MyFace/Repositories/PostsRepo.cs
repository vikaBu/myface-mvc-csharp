using System;
using System.Collections.Generic;
using MyFace.Models.Database;
using MyFace.Models.Request;

namespace MyFace.Repositories
{
    public interface IPostsRepo
    {
        IEnumerable<Post> GetAll();
        void CreatePost(CreatePostRequestModel postModel);
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

        public void CreatePost(CreatePostRequestModel postModel)
        {
            _context.Posts.Add(new Post
            {
                ImageUrl = postModel.ImageUrl,
                Message = postModel.Message,
                PostedAt = DateTime.Now,
            });
            _context.SaveChanges();
        }
    }
}