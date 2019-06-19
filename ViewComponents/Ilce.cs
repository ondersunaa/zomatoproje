using ETicaret.Interface;
using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewComponents
{
    public class Ilce: ViewComponent
    {
        private Iilce ilce;
        public Ilce(Iilce _ilce)
        {
            ilce = _ilce;
        }
        public IViewComponentResult Invoke(int id)
        {
            var a = ilce.IlceBul(id);
            return View(a);

        }
    }
}
