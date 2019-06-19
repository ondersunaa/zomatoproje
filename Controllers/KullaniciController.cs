using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class KullaniciController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public KullaniciController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
        }
        [HttpGet]
        public IActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Creat(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = kullanici.Isim;
                user.Email = kullanici.Mail;
                user.PhoneNumber = kullanici.Tel;
                var result = await userManager.CreateAsync(user, kullanici.Parola);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(kullanici);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login obj)
        {
            if (ModelState.IsValid)
            {
                // Girilen kullanıcı adına sahip kullanıcı varse user değişkenine atıyoruz
                var user = await userManager.FindByNameAsync(obj.username);
               

                // eğer kullanıcı varsa if içerisine giriyoruz
                if (user != null)
                {
                    // kullanıcı girişi yapıyoruz
                    var result = await signInManager.PasswordSignInAsync(user, obj.Parola, false, false);

                    // eğer giriş ilemi başarılıysa anasayfaya yönlendiriyoruz
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                // böyle bir kullanıcı yoksa geriye hata döndürüyoruz
                // ilk parametre key ikinci parametre value
                ModelState.AddModelError("", "Kullanıcı Bulunamadı.");
                return View(obj);
            }
            return View(obj);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}