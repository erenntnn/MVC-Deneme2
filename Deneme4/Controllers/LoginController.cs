using Microsoft.AspNetCore.Authorization;
using Deneme4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Deneme4.Controllers
{
    
    public class LoginController : Controller
    {
        Context c = new Context();

        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task< IActionResult> Index(Admin p)
        {
            var datavalue = c.admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if(datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Username)
                };  
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Student");
            }
                
            return View();

        }
    }
}
