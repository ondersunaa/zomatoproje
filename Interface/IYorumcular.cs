
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Interface
{
  public  interface IYorumcular
    {
        IQueryable<Yorumcular> yorumcular { get; }
        List<Yorumcular> Yorumcular();
        Yorumcular YorumcuBul(int id);
    }
}
