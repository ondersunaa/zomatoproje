using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Interface
{
   public interface IKategori
    {
        IQueryable<Kategori> kategoriler { get; }
        List<Kategori> Kategoriler();
        
    }
}
