using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Interface
{
   public interface IMenu
    {
        IQueryable<Menu> menuler { get; }
        List<Menu> Menuler();
        List<Menu> MenuBul(string id);
        void MenuEkle(Menu menu);
       void MenuGuncelle(Menu menu);
       void MenuSil(int id);
        string MagazaBul(int id);
        Menu UrunBul(int id);
    }
}
