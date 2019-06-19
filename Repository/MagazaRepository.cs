using ETicaret.Interface;
using ETicaret.Models;
using ETicaret.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Repository
{
    public class MagazaRepository : IMagaza
    {
        private Context con;
        public IQueryable<Magaza> magazalar => con.Magazas;
        public MagazaRepository(Context _con)
        {
            con = _con;
        }

        public List<Magaza> MagazaBul(int Id)
        {
            var a = con.Magazas.Where(x => x.IlID == Id).ToList();
            return a;
        }

        public void MagazaEkle(Magaza magaza)
        {
            con.Magazas.Add(magaza);
            con.SaveChanges();
        }

        public Magaza MagazaGuncelle(Magaza magaza)
        {
            con.Magazas.Update(magaza);
            con.SaveChanges();
            return magaza;
        }

        public List<Magaza> Magazalar()
        {
            throw new NotImplementedException();
        }

        public Magaza MagazaDetay(int id)
        {
            var a = con.Magazas.Where(x => x.MagazaId == id).FirstOrDefault();
            return (a);
        }

        public List<Magaza> IlceMagazaBul(int Ilceid, int TurID)
        {
            var a = con.Magazas.Where(x => x.IlceID == Ilceid && x.MagazaTur == TurID).ToList();
            return a;
        }

        public List<Magaza> TurMagazaBul(int id)
        {
            throw new NotImplementedException();
        }

        public List<Magaza> filitremagaza(MagazaIlceViewModel mtm)
        {

            List<Magaza> filitremagaza = new List<Magaza>();
            bool alkol = mtm.Alkol;
            bool wifi = mtm.Wifi;
            bool otopark = mtm.Otopark;
            bool oyun = mtm.Oyun;
            bool acikalan = mtm.AcikAlan;
            bool yayin = mtm.MacYayini;
            bool kart = mtm.KKart;
            int ilceID = mtm.SelectedID;
            int TurID = mtm.SelectedIDTur;
            if (TurID==0)
            {
                filitremagaza = con.Magazas.Where(x => x.IlceID == ilceID).ToList();
            }
            else
            {
                filitremagaza = con.Magazas.Where(x => x.IlceID == ilceID && x.MagazaTur == TurID).ToList();
            }

            if (alkol)
            {
             filitremagaza = filitremagaza.Where(x => x.Alkol == alkol).ToList();
            }
            //else
            //{
            //    filitremagaza = filitremagaza.Where(x => x.Alkol == alkol).ToList();
            //}
            if (wifi)
            {
                filitremagaza =filitremagaza.Where(x => x.Wifi == wifi).ToList();
            }
            //else
            //{
            //    filitremagaza = filitremagaza.Where(x => x.Wifi == wifi).ToList();
            //}
            if (otopark)
            {
                filitremagaza = filitremagaza.Where(x => x.Otopark == otopark).ToList();
            }
            //else
            //{
            //    filitremagaza = filitremagaza.Where(x => x.Otopark == otopark).ToList();
            //}
            if (oyun)
            {
                filitremagaza = filitremagaza.Where(x => x.Oyun == oyun).ToList();
            }
            //else
            //{
            //    filitremagaza = filitremagaza.Where(x => x.Oyun == oyun).ToList();
            //}
            if (acikalan)
            {
                filitremagaza = filitremagaza.Where(x => x.AcikAlan == acikalan).ToList();
            }
            //else
            //{
            //    filitremagaza = filitremagaza.Where(x => x.AcikAlan == acikalan).ToList();
            //}
            if (yayin)
            {
                filitremagaza = filitremagaza.Where(x => x.MacYayini == yayin).ToList();
            }
            //else
            //{
            //    filitremagaza = filitremagaza.Where(x => x.MacYayini == yayin).ToList();
            //}
            if (kart)
            {
                filitremagaza = filitremagaza.Where(x => x.Kart == kart).ToList();
            }
            //else
            //{
            //    filitremagaza = filitremagaza.Where(x => x.Kart == kart).ToList();
            //}
            if (alkol&&otopark&&acikalan&&kart&&wifi&&oyun&&yayin == false)
            {
                if (TurID == 0)
                {
                    filitremagaza = con.Magazas.Where(x => x.IlceID == ilceID).ToList();
                }
                else
                {
                    filitremagaza = con.Magazas.Where(x => x.IlceID == ilceID && x.MagazaTur == TurID).ToList();
                }
            }
           
            return filitremagaza;

        }

        public  string MagazaTur(int a)
        {
            string tur=null;
            switch (a)
            {
                case 1:
                    tur = "Ye ve Kalk";
                    break;
                case 2:
                    tur = "Restorant";
                    break;
                case 3:
                    tur = "Cafe&PUB";
                    break;
                case 4:
                    tur = "Bar";
                    break;
                case 5:
                    tur = "Meyhane";
                    break;
                case 6:
                    tur = "Lüks Restorant";
                    break;
                
            }
            return tur;
        }

        public List<string> Ozellikler(int id)
        {
            List<string> liste = new List<string>();
           var a = con.Magazas.Where(x => x.MagazaId == id).FirstOrDefault();
            if (a.AcikAlan)
            {
                liste.Add("Açik Alan");
            }
            if (a.Alkol)
            {
                liste.Add("Alkol Servisi");
            }
            if (a.Kart)
            {
                liste.Add("Kredi Kartı Geçerli");
            }
            if (a.MacYayini)
            {
                liste.Add("Maç Yayını");
            }
            if (a.Otopark)
            {
                liste.Add("Otopark");
            }
            if (a.Oyun)
            {
                liste.Add("Oyun");
            }
            if (a.Wifi)
            {
                liste.Add("Wi-Fi");
            }
            return liste;
        }

        public Magaza UserMagazaBul(string id)
        {
           var a = con.Magazas.Where(x => x.UserID == id).FirstOrDefault();
            return a;
        }
    }
}
