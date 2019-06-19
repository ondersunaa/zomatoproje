using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Interface;
using ETicaret.Models;
using ETicaret.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class MagazaController : Controller
    {
        private IMagaza magazas;
        private IMenu menus;
        private IIller il;
        private IYorumlar yorumlar;
        private Iilce ilce;
        private IKategori kategori;

        private UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public MagazaController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, IMagaza _magazas, IIller _il, IMenu _menus, IYorumlar _yorumlar, Iilce _ilce, IKategori _kategori)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            magazas = _magazas;
            il = _il;
            menus = _menus;
            yorumlar = _yorumlar;
            ilce = _ilce;
            kategori = _kategori;
        }
        [Authorize]
        public IActionResult Index(string id)
        {
            var a = magazas.UserMagazaBul(id);
            MagazaMenuViewModel model = new MagazaMenuViewModel();
            model.Menu = menus.MenuBul(id);
            model.MagazaOzellik = magazas.Ozellikler(a.MagazaId);
            model.MagazaOrt = yorumlar.PuanOrt(a.MagazaId);
            model.Il = il.IlBul(a.IlID);
            model.MagazaTur = magazas.MagazaTur(a.MagazaTur);
            model.Yorumlar = yorumlar.YorumGetir(a.MagazaId);
            model.Magaza = a;


            return View(model);
        }
        public IActionResult Menu(string id)
        {
            var a = magazas.UserMagazaBul(id);
            MagazaMenuViewModel model = new MagazaMenuViewModel();
            model.Menu = menus.MenuBul(id);
            model.Magaza = a;
            return View(model);
        }
        [HttpGet]
        public IActionResult Creat()
        {


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Creat(MagazaKullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                #region İdentity Tablosu kayıt
                Magaza magaza = new Magaza();
                ApplicationUser user = new ApplicationUser();
                user.UserName = kullanici.KullaciAdi;
                user.Email = kullanici.MagazaMail;
                user.PhoneNumber = kullanici.MagazaTel;
                user.MagazaAdi = kullanici.MagazaAdi;
                user.MagazaTanitim = kullanici.MagazaTanitim;
                user.MagazaTur = kullanici.MagazaTur;
                user.AcikAlan = kullanici.AcikAlan;
                user.Alkol = kullanici.Alkol;
                user.FotoGenel = kullanici.FotoGenel;
                user.FotoGenel2 = kullanici.FotoGenel2;
                //user.IlceID = kullanici.IlceID;
                user.IlID = kullanici.IlID;
                user.Kapasite = kullanici.Kapasite;
                user.Kart = kullanici.Kart;
                user.MacYayini = kullanici.MacYayini;
                user.MagazaAdres = kullanici.MagazaAdres;
                user.Otopark = kullanici.Otopark;
                user.Oyun = kullanici.Oyun;
                user.Wifi = kullanici.Wifi;
                #endregion
                #region Magaza Tablosu Kayıt
                magaza.Wifi = kullanici.Wifi;
                magaza.Oyun = kullanici.Oyun;
                magaza.Otopark = kullanici.Otopark;
                magaza.MagazaTur = kullanici.MagazaTur;
                magaza.MagazaTel = kullanici.MagazaTel;
                magaza.MagazaTanitim = kullanici.MagazaTanitim;
                magaza.MagazaMail = kullanici.MagazaMail;
                magaza.MagazaAdres = kullanici.MagazaAdres;
                magaza.MagazaAdi = kullanici.MagazaAdi;
                magaza.MacYayini = kullanici.MacYayini;
                magaza.Kart = kullanici.Kart;
                magaza.Kapasite = kullanici.Kapasite;
                magaza.IlID = kullanici.IlID;
                //magaza.IlceID = kullanici.IlceID;
                magaza.FotoGenel2 = kullanici.FotoGenel2;
                magaza.FotoGenel = kullanici.FotoGenel;
                magaza.Alkol = kullanici.Alkol;
                magaza.AcikAlan = kullanici.AcikAlan;
                magaza.UserID = user.Id;
                magazas.MagazaEkle(magaza);
                #endregion
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
        public async Task<IActionResult> Login(MagazaLogin obj)
        {
            if (ModelState.IsValid)
            {
                // Girilen kullanıcı adına sahip kullanıcı varse user değişkenine atıyoruz
                var user = await userManager.FindByNameAsync(obj.MagazaIsim);
                var id = user.Id;
                // eğer kullanıcı varsa if içerisine giriyoruz
                if (user != null && user.MagazaAdi != null)
                {

                    // kullanıcı girişi yapıyoruz
                    var result = await signInManager.PasswordSignInAsync(user, obj.Parola, false, false);


                    // eğer giriş ilemi başarılıysa anasayfaya yönlendiriyoruz
                    if (result.Succeeded)
                    {
                        var a = magazas.UserMagazaBul(id);
                        MagazaMenuViewModel model = new MagazaMenuViewModel();
                        model.Menu = menus.MenuBul(id);
                        model.MagazaOzellik = magazas.Ozellikler(a.MagazaId);
                        model.MagazaOrt = yorumlar.PuanOrt(a.MagazaId);
                        model.Il = il.IlBul(a.IlID);
                        model.MagazaTur = magazas.MagazaTur(a.MagazaTur);
                        model.Yorumlar = yorumlar.YorumGetir(a.MagazaId);
                        model.Magaza = a;
                        return View("Index", model);
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
        public IActionResult Yorumlar(string id)
        {
            var a = magazas.UserMagazaBul(id);
            MagazaMenuViewModel model = new MagazaMenuViewModel();
            model.Yorumlar = yorumlar.YorumGetir(a.MagazaId);
            model.Magaza = a;
            return View(model);
        }
        public IActionResult Sil(int id)
        {
            var a = menus.MagazaBul(id);
            menus.MenuSil(id);
            var b = magazas.UserMagazaBul(a);
            MagazaMenuViewModel model = new MagazaMenuViewModel();
            model.Menu = menus.MenuBul(a);
            model.Magaza = b;
            return View("Menu", model);
        }
        public IActionResult MenuEkle(Menu menu)
        {
            menus.MenuEkle(menu);
            var a = menu.MagazaID;
            var magaza = magazas.UserMagazaBul(a);
            MagazaMenuViewModel model = new MagazaMenuViewModel();
            model.Menu = menus.MenuBul(a);
            model.Magaza = magaza;
            return View("Menu", model);
        }
        public IActionResult MenuGuncelle(int id)
        {
            var a = menus.UrunBul(id);

            return View(a);
        }
        [HttpPost]
        public IActionResult MenuGuncelle(Menu menu)
        {
            menus.MenuGuncelle(menu);
            var a = menu.MagazaID;
            var magaza = magazas.UserMagazaBul(a);
            MagazaMenuViewModel model = new MagazaMenuViewModel();
            model.Menu = menus.MenuBul(a);
            model.Magaza = magaza;
            return View("Menu", model);
        }
        public IActionResult Bilgiler(string id)
        {

            MagazaBilgiViewModel bilgiler = new MagazaBilgiViewModel();
            var a = magazas.UserMagazaBul(id);
            int b = a.IlID;
            bilgiler.Ilismi = il.IlBul(a.IlID).Ilismi;
            bilgiler.Ilceler = ilce.IlceBul(b);
            bilgiler.Magaza = a;
            bilgiler.Kategoriler = kategori.Kategoriler();
            return View(bilgiler);
        }
        [HttpPost]
        public IActionResult Bilgiler(Magaza magaza)
        {
            var a = magaza.IlceID;
            int ab = ilce.IlBul(a);
            magaza.IlID = ab;
            var b = magazas.MagazaGuncelle(magaza);
            
            return View("Index", b.UserID);
        }
    }
}