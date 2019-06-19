using ETicaret.Models;
using ETicaret.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Interface
{
    public interface IYorumlar
    {
        IQueryable<Yorum> yorumlars { get; }
        List<Yorum> Yorumlars();
        List<Yorum> YorumGetir(int id);
        Yorum YorumEkle(Yorum yorum);
        double PuanOrt(int id);
    }
}
