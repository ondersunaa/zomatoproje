using ETicaret.Interface;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
   
    public class MenuRepository : IMenu
    {
        private Context con;
      
        public IQueryable<Menu> menuler => con.Menus;
        public MenuRepository(Context _con)
        {
            con = _con;
        }

        public List<Menu> MenuBul(string id)
        {
           var a = con.Menus.Where(x => x.MagazaID == id).ToList();
            return a;
        }

        public void MenuEkle(Menu menu)
        {
            con.Add(menu);
            con.SaveChanges();
        }

        public void MenuGuncelle(Menu menu)
        {
            con.Menus.Update(menu);
            con.SaveChanges();
        }

        public List<Menu> Menuler()
        {
            throw new NotImplementedException();
        }

        public void MenuSil(int id)
        {
            var a = con.Menus.Where(x => x.Id == id).FirstOrDefault();
            con.Entry(a).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            con.SaveChanges();
        }

        public string MagazaBul(int id)
        {
            var a = con.Menus.Where(x=> x.Id == id).FirstOrDefault();
            
            return a.MagazaID;
            
        }

        public Menu UrunBul(int id)
        {
           var a = con.Menus.Where(x => x.Id == id).FirstOrDefault();
            return a;
        }
    }
}
