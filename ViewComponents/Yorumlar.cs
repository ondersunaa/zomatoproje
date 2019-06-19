using ETicaret.Interface;
using ETicaret.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewComponents
{
    public class Yorumlar: ViewComponent
    {
        private IYorumlar yorum;
      
        public Yorumlar(IYorumlar yorum)
        {
            this.yorum = yorum;
           
        }
        public IViewComponentResult Invoke(int id)
        {
           
            var a = yorum.YorumGetir(id).ToList();
            return View(a);

        }
    }
}
