using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Interface
{
  public  interface Iilce
    {
        IQueryable<Ilceler> ilceler { get; }
        List<Ilceler> Ilceler();
        List<Ilceler> IlceBul(int id);
        int IlBul(int id);
        
    }
}
