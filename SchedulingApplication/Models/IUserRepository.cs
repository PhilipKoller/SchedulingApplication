using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingApplication.Models
{
    public interface IUserRepository
    {
        //Why this? Because an interface helps to retreive and save data
        // This also allows for dependency injection
        User GetUser(int Id);

        // IEnumerable will let us iterate over Users so we can make a table in the view 
        IEnumerable<User> GetAllUsers();

        User Add(User user);

        User Update(User updateUser);

        User Delete(int id);

  

    }
}
