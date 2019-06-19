using ETicaret.Interface;
using ETicaret.Migrations;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class KategoriRepository: IKategori
    {
        private Context con;

        public IQueryable<Models.Kategori> kategoriler => con.Kategoris;
        public KategoriRepository(Context _con)
        {
            con = _con;
        }

        public List<Models.Kategori> Kategoriler()
        {
            return con.Kategoris.ToList();
        }
    }
}
