using ETicaret.Interface;
using ETicaret.Models;
using ETicaret.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class YorumlarRepository :IYorumlar
    {
        private Context con;
        public IQueryable<Yorum> yorumlars => con.Yorums;
        public YorumlarRepository(Context _con)
        {
            con = _con;
        }
        public List<Yorum> YorumGetir(int id)
        {
            var a = con.Yorums.Where(x => x.MagazaId == id).ToList();
            return a;
        }

        public List<Yorum> Yorumlars()
        {
            throw new NotImplementedException();
        }
        public Yorum YorumEkle(Yorum yorum)
        {
            con.Yorums.Add(yorum);
            con.SaveChanges();
            return yorum;
        }

        public double PuanOrt(int id)
        {
            double puan = 0;
            var a = con.Yorums.Where(x => x.MagazaId == id).ToList();
            foreach (var item in a)
            {
                puan += item.Puan;
            }
            return puan / a.Count;
        }
    }
}
