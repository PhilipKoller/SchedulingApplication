using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingApplication.Models
{
    public class MockUserRepository : IUserRepository
    {

        private List<User> _userList;
        public MockUserRepository()
        {
            _userList = new List<User>()
            {
                new User() { Id = 1, Email = "venolium@gmail.com", Password = "FDSOIU&*", Phone = "9072363544", Area = Area.CampHorno, FirstName = "Philip", LastName ="Koller", Rank = Rank.Cpl},
                new User() { Id = 2, Email = "shelly@gmail.com", Password = "Root34&*", Phone = "9878844",  Area = Area.LasPulgas, FirstName = "john", LastName ="Tron", Rank = Rank.PFC },
                new User() { Id = 3, Email = "billymilly@gmail.com", Password = "grood&*", Phone = "8989783443" , Area = Area.SOI, FirstName = "Nick", LastName ="Hartley", Rank = Rank.GySgt}
            };
        }

        public User GetUser(int Id)
        {
            return _userList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User Add(User user)
        {
           user.Id = _userList.Max(e=>e.Id) + 1;
           user.Phone = "000-000-0000";
            _userList.Add(user);
            return user;
        }

        public User Update(User updateUser)
        {
            User user = _userList.FirstOrDefault(user => user.Id == updateUser.Id);
            if (user != null)
            {
                user.Password = updateUser.Password;
                user.Email = updateUser.Email;
                user.Phone = updateUser.Phone;
                user.Area = updateUser.Area;

            }
            return user;

        }

        public User Delete(int id)
        {
            User user = _userList.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                _userList.Remove( user );
            }
            return user;
        }


    }
}
