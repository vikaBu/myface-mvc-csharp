using System;
using System.Collections.Generic;
using MyFace.Models.Database;
using MyFace.Models.Request;

namespace MyFace.Repositories
{
    public interface IPostsRepo
    {
        IEnumerable<Post> GetAll();
        void CreatePost(CreatePostRequestModel postModel, User postedBy);
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

        public void CreatePost(CreatePostRequestModel postModel, User postedBy)
        {
            _context.Posts.Add(new Post
            {
                ImageUrl = postModel.ImageUrl,
                Message = postModel.Message,
                PostedAt = DateTime.Now,
                PostedBy = postedBy,
            });
            _context.SaveChanges();
        }
    }
}