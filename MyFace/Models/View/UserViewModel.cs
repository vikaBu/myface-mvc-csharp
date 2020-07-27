using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class UserViewModel
    {
        private readonly User _user;
        public int NumPosts { get; }
        public int NumLikes { get; }
        public int NumDislikes { get; }

        public UserViewModel(User user, int numPosts = 8, int numLikes = 8, int numDislikes = 8)
        {
            _user = user;
            NumPosts = numPosts;
            NumLikes = numLikes;
            NumDislikes = numDislikes;
            
            Posts = user.Posts
                .Take(NumPosts)
                .Select(post => new PostViewModel(post));
            Likes = user.Interactions
                .Where(interaction => interaction.Type == InteractionType.LIKE)
                .Take(NumLikes)
                .Select(interaction => new PostViewModel(interaction.Post));
            Dislikes = user.Interactions
                .Where(interaction => interaction.Type == InteractionType.DISLIKE)
                .Take(NumDislikes)
                .Select(interaction => new PostViewModel(interaction.Post));
        }

        public int Id => _user.Id;
        public string FirstName => _user.FirstName;
        public string LastName => _user.LastName;
        public string DisplayName => $"{FirstName} {LastName}";
        public string Username => _user.Username;
        public string Email => _user.Email;
        public string ProfileImageUrl => _user.ProfileImageUrl;
        public string CoverImageUrl => _user.CoverImageUrl;
        
        public IEnumerable<PostViewModel> Posts { get; }
        public IEnumerable<PostViewModel> Likes { get; }
        public IEnumerable<PostViewModel> Dislikes { get; }

        public string ShowMorePostsUrl => $"/users/{Id}?numPosts={NumPosts+8}&numLikes={NumLikes}&numDislikes={NumDislikes}";
        public string ShowMoreLikesUrl => $"/users/{Id}?numPosts={NumPosts}&numLikes={NumLikes+8}&numDislikes={NumDislikes}";
        public string ShowMoreDislikesUrl => $"/users/{Id}?numPosts={NumPosts}&numLikes={NumLikes}&numDislikes={NumDislikes+8}";

        public bool HasMorePosts => Posts.Count() == NumPosts;
        public bool HasMoreLikes => Likes.Count() == NumLikes;
        public bool HasMoreDislikes => Dislikes.Count() == NumDislikes;
    }
}