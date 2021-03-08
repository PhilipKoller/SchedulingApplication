using Microsoft.AspNetCore.Mvc;
using SchedulingApplication.Models;
using SchedulingApplication.ViewModels;
using System.Collections.Generic;

namespace SchedulingApplication.Controllers
{
    public class HomeController : Controller
    {
        //private IUserRepository _userRepository;
        //public HomeController(IUserRepository userRepository)
        //{
        //    _userRepository = userRepository;
        //}

        //public ViewResult Details(int id=1)
        //{
        //   // SQLUserRepository AllUsers = new SQLUserRepository() { };
        //    HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
        //    {
        //        User = _userRepository.GetUser(id),
        //        PageTitle = "User Details"
                
        //    };
        //   IEnumerable<User> model= _userRepository.GetAllUsers();
        //    return View(model);
        //}
        [HttpGet]
        public IActionResult Index() 
        {
            return RedirectToAction("Login", "Account");
        }

        //[HttpPost]
        //public IActionResult Index(User user)
        //{
        //    //    if (_userRepository.ValidateUser(user.Email, user.Password))
        //    //    {
        //    //        // Need To retreive Email And Pass From database and check before
        //    //        // Redirecting 

        //    //        return RedirectToAction("Event","Calendar");
        //    //    }

        //    return RedirectToAction("Event", "Calendar");
        //    // return View();

        //}
      
       
    }
}
