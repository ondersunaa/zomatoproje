using ETicaret.Interface;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class IllerRepository : IIller
    {
        private Context con;

        public IQueryable<Iller> iller => con.Illers;
        public IllerRepository(Context _con)
        {
            con = _con;
        }

        public List<Iller> Iller()
        {
            return con.Illers.ToList();
        }

        public Iller IlBul(int id)
        {
            var a = con.Illers.Where(x => x.ID == id).FirstOrDefault();
            return a;
        }
    }
}
