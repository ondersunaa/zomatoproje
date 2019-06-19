using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Interface;
using ETicaret.Models;
using ETicaret.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class HomeController : Controller
    {
        private IMenu menu;
        private IProduct repo;
        private IMagaza maga;
        private IIller il;
        private Iilce ilce;
        private IKategori kategori;
        private IYorumlar yorum;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public HomeController(IProduct _repo, IMagaza _maga, IIller _il, Iilce _ilce, IKategori _kategori, IYorumlar _yorum, UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, IMenu _menu)
        {
            repo = _repo;
            maga = _maga;
            il = _il;
            ilce = _ilce;
            kategori = _kategori;
            yorum = _yorum;
            userManager = _userManager;
            signInManager = _signInManager;
            menu = _menu;
        }

        public IActionResult Index()
        {

            MagazaIlViewModel magaz = new MagazaIlViewModel();
            magaz.magazas = maga.magazalar.ToList();
            magaz.IllerList = il.iller.ToList();
            return View(magaz);
        }
        public IActionResult Filitre(MagazaIlViewModel mvm)
        {
            if (mvm.SelectedID == 0)
            {
                mvm.SelectedID = 1;
            }
            MagazaIlceViewModel ilceler = new MagazaIlceViewModel();
            ilceler.ilcelers = ilce.IlceBul(mvm.SelectedID);
            ilceler.Magazalar = maga.MagazaBul(mvm.SelectedID);
            ilceler.Ilismi = il.IlBul(mvm.SelectedID).ToString();
            ilceler.IlList = il.Iller();
            ilceler.Kategoriler = kategori.Kategoriler();
            string a = ilceler.Ilismi;
            return View(ilceler);




        }
        [HttpPost]
        public IActionResult Ilce(MagazaIlViewModel mvm)
        {
            return View(mvm.SelectedID);
        }
        [HttpPost]
        public async Task<IActionResult> YorumEkle(DetayViewModel yorumgelen)
        {

            int magaID = yorumgelen.MagazaId;
            ModelState.Clear();
            var user = await userManager.GetUserAsync(HttpContext.User);
            yorumgelen.user = user.Id;
            //var aa = yorumgelen.user.Id;
            TryValidateModel(yorumgelen);
            if (ModelState.IsValid)
            {

                yorum.YorumEkle(yorumgelen);
                DetayViewModel detay = new DetayViewModel();
                var a = maga.MagazaDetay(yorumgelen.MagazaId);
                detay.Magaza = a;
                int b = a.MagazaTur;
                detay.MagazaTur = maga.MagazaTur(b);
                detay.MagazaOrtalama = yorum.PuanOrt(a.MagazaId);
                detay.Il = il.IlBul(a.IlID);
                detay.Ozellikler = maga.Ozellikler(a.MagazaId);
                return RedirectToAction("Detay", new { id = yorumgelen.MagazaId });
            }
            else
            {
                DetayViewModel detay = new DetayViewModel();
                var a = maga.MagazaDetay(yorumgelen.MagazaId);
                detay.Magaza = a;
                int b = a.MagazaTur;
                detay.MagazaTur = maga.MagazaTur(b);
                detay.MagazaOrtalama = yorum.PuanOrt(a.MagazaId);
                detay.Il = il.IlBul(a.IlID);
                detay.Ozellikler = maga.Ozellikler(a.MagazaId);
                return View("Detay", detay);
            }



        }
        public IActionResult Detay(int id)
        {
            DetayViewModel detay = new DetayViewModel();
            var a = maga.MagazaDetay(id);
           var aa= a.UserID;
            detay.Menu = menu.MenuBul(aa);
            detay.Magaza = a;
            detay.MagazaId = id;
            detay.Magaza.MagazaId = id;
            int b = a.MagazaTur;
            detay.MagazaTur = maga.MagazaTur(b);
            detay.MagazaOrtalama = yorum.PuanOrt(a.MagazaId);
            detay.Il = il.IlBul(a.IlID);
            detay.Ozellikler = maga.Ozellikler(a.MagazaId);
            return View(detay);
        }
        public IActionResult MagazaFilitre(MagazaIlceViewModel mtm)
        {
            MagazaIlceViewModel ilceler = new MagazaIlceViewModel();
            //ilceler.Magazalar = maga.IlceMagazaBul(mtm.SelectedID, mtm.SelectedIDTur);

            ilceler.Kategoriler = kategori.Kategoriler();
            ilceler.ilcelers = ilce.IlceBul(1);
            ilceler.IlList = il.Iller();
            var sss = maga.filitremagaza(mtm);
            ilceler.Magazalar = sss;
            //var a = maga.filitremagaza(mtm);
            return View("Filitre", ilceler);
        }
    }
}