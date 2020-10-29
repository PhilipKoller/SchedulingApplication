using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingApplication.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public SQLUserRepository(AppDbContext context)
        {
            _context = context;
        }
        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Delete(int Id)
        {
            User user = _context.Users.Find(Id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User GetUser(int Id)
        {
            return _context.Users.Find(Id);
        }
      
        public User Update(User updateUser)
        {
            var user = _context.Users.Attach(updateUser);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updateUser;
        }
    }
}
