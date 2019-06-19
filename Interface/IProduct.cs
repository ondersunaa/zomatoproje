using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Interface
{
   public interface IProduct
    {
        IQueryable<Product> Uruns { get; }
        List<Product> Urunler();
        Product UrunBul(int Id);
        int UrunEkle(Product urun);
        Product UrunGuncelle(Product urun);
        bool UrunSil(int Id);
    }
}
