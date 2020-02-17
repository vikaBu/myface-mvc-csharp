using System;
using MyFace.Models.Database;
using MyFace.Models.Request;

namespace MyFace.Repositories
{
    public interface IInteractionsRepo
    {
        void Create(CreateInteractionRequestModel newInteraction, Post post, User user);
    }
    
    public class InteractionsRepo : IInteractionsRepo
    {
        private readonly MyFaceDbContext _context;

        public InteractionsRepo(MyFaceDbContext context)
        {
            _context = context;
        }
        
        public void Create(CreateInteractionRequestModel newInteraction, Post post, User user)
        {
            _context.Interactions.Add(new Interaction
            {
                Type = newInteraction.InteractionType,
                Post = post,
                User = user,
                Date = DateTime.Now,
            });
            _context.SaveChanges();
        }
    }
}