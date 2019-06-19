using ETicaret.Interface;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class IlcelerRepository : Iilce
    {
        private Context con;
        public IQueryable<Ilceler> ilceler => con.Ilcelers;
        public IlcelerRepository(Context _con)
        {
            con = _con;
        }
        public List<Ilceler> IlceBul(int id)
        {
            var a = con.Ilcelers.Where(x => x.IlID == id).ToList();
            return a;
        }

        public List<Ilceler> Ilceler()
        {
            throw new NotImplementedException();
        }

        public int IlBul(int id)
        {
           
           var a = con.Ilcelers.Where(x => x.ID == id).FirstOrDefault();
            return a.IlID;
            
            
        }
    }
}
