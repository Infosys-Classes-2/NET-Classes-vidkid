using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public AuthController(RoleManager<IdentityRole> rolemanager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = rolemanager;
        }
        public IActionResult Roles()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }
        public IActionResult AddRole()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(IdentityRole role)
        {
            var result = await roleManager.CreateAsync(role);
            return RedirectToAction(nameof(Roles));
        }
        public IActionResult AssignRole()
        {
            return View();
        }
    }
}
