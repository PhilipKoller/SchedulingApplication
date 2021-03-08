using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchedulingApplication.Models;
using System.Threading.Tasks;

namespace SchedulingApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, 
                                SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
       public async Task<IActionResult> Logout()
        {
           await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Registration(User user)
        {

            if (ModelState.IsValid)
            {
                var uUser = new IdentityUser { UserName = user.Email, Email = user.Email };
               var result =  await userManager.CreateAsync(uUser, user.Password);

                if (result.Succeeded)
                {
                   await signInManager.SignInAsync(uUser, isPersistent: false);
                    return RedirectToAction("Event", "Calendar");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //_userRepository.Add(user);
                //return RedirectToAction();
            }

            return View(user);
        }


        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Event", "Calendar");
                }

               
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                }

                //_userRepository.Add(user);
                // return RedirectToAction("Index"); 
            return View(model);
            }

           
        }
    }



