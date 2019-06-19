using ETicaret.Interface;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class ProductRepository: IProduct
    {
        private Context con;
        public IQueryable<Product> Uruns => con.Products;
        public ProductRepository(Context _con)
        {
            con = _con;
        }

        public Product UrunBul(int Id)
        {
            throw new NotImplementedException();
        }

        public int UrunEkle(Product urun)
        {
            con.Products.Add(urun);
            con.SaveChanges();
            return urun.Id;
        }

        public Product UrunGuncelle(Product urun)
        {
            throw new NotImplementedException();
        }

        public List<Product> Urunler()
        {
            throw new NotImplementedException();
        }

        public bool UrunSil(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
