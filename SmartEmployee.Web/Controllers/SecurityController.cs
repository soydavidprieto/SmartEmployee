using Microsoft.AspNetCore.Mvc;
using SmartEmployee.Web.Helpers;
using SmartEmployee.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SmartEmployee.Web.Controllers
{
    public class SecurityController : Controller
    {
        private readonly IUserHelper _userHelper;

        public SecurityController(IUserHelper userHelper)
        {
            _userHelper = userHelper;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Failed to login.");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Login", "Security");
        }
    }
}
