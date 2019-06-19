using ETicaret.Models;
using ETicaret.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Interface
{
   public interface IMagaza
    {
        IQueryable<Magaza> magazalar { get; }
        List<Magaza> Magazalar();
        List<Magaza> MagazaBul(int Id);
        void MagazaEkle(Magaza magaza);
        Magaza MagazaDetay(int id);
        Magaza MagazaGuncelle(Magaza magaza);
        List<Magaza> IlceMagazaBul(int Ilceid, int TurID);
        List<Magaza> TurMagazaBul(int id);
        List<Magaza> filitremagaza(MagazaIlceViewModel mtm);
        string MagazaTur(int a);
        List<string> Ozellikler(int id);
        Magaza UserMagazaBul(string id);
       
    }
}
