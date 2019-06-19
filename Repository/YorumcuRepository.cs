using ETicaret.Interface;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class YorumcuRepository : IYorumcular
    {
        private Context con;
        public IQueryable<Yorumcular> yorumcular => con.Yorumculars;
        public YorumcuRepository(Context _con)
        {
            con = _con;
        }
        public Yorumcular YorumcuBul(int id)
        {
            var a = con.Yorumculars.Where(x => x.ID == id).FirstOrDefault();
            return a;
        }

        public List<Yorumcular> Yorumcular()
        {
            var a = con.Yorumculars.ToList();
            return a;
        }
    }
}
