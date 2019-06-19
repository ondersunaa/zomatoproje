using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Interface;
using ETicaret.Models;
using ETicaret.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DefaultController : Controller
    {
        private IProduct repo;
        public DefaultController(IProduct _repo)
        {
            repo = _repo;
        } 

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Product product)
        {

            repo.UrunEkle(product);
            
            return View(product);
        }
    }
}