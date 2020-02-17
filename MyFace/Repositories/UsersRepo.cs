using System.Collections.Generic;
using MyFace.Models.Database;

namespace MyFace.Repositories
{
    public interface IUsersRepo
    {
        IEnumerable<User> GetAll();
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
    }
}