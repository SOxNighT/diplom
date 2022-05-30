using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using JWT.Domain.Models;
using JWT.Infrastructure.Context;
using JWT.Domain.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Main.Extensions;

namespace JWT.Controllers
{
    public class AccountController : Controller
    {
        private UserContext _context;
        public AccountController(UserContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Register()
        {
            if(User.Identity.IsAuthenticated) 
                return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _context.Users.Where(u=>!u.IsDelete).FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    user = new User 
                    { 
                        Email = model.Email, 
                        PasswordHash = model.Password.GetHashString(), 
                        Name = model.Name, 
                        Token = model.AccessToken
                    };

                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();

                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            if (ModelState.IsValid)
            {
                User user = await _context.Users
                    .Where(u => !u.IsDelete)
                    .FirstOrDefaultAsync(u => u.Email == model.Email && u.PasswordHash == model.Password.GetHashString());
                if (user != null)
                {
                    await Authenticate(user); // аутентификация

                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(ViewBag.ReturnUrl) && Url.IsLocalUrl(ViewBag.ReturnUrl))
                    {
                        return Redirect(ViewBag.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email)             
            };

            claims.Add(CreateClaim("Name", user.Name));
            claims.Add(CreateClaim("Id", user.Id.ToString()));

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        private static Claim CreateClaim(string type, string value)
        {
            return new Claim(type, value, ClaimValueTypes.String, "RemoteClaims");
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

    }
}