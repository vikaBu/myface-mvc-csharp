using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;

namespace MyFace.Repositories
{
    public interface IUsersRepo
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
    
    public class UsersRepo : IUsersRepo
    {
        private readonly MyFaceDbContext _context;

        public UsersRepo(MyFaceDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(int id)
        {
            return _context.Users
                .Single(user => user.Id == id);
        }
    }
}