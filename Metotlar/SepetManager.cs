using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)   // class ( urunsınıfı)
        {
            Console.WriteLine("tebrikler, sepete eklendi : " + urun.Adi); 

        }
        
        public void Ekle2(string urunAdi,string aciklama, double fiyat, int stokadeti)
        {
            Console.WriteLine("tebrikler, sepete eklendi : " +urunAdi);

        }

    }
}
