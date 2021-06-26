using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();

            urun1.Adi = " Elma ";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması ";
            urun1.stokAdeti = 15;
            urun1.IndirimOrani = "50%";

            Urun urun2 = new Urun();
            urun2.Adi = " Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "karpuz iyidir";
            urun2.stokAdeti = 20;
            urun2.IndirimOrani = "60%";

            Urun urun3 = new Urun();
            urun3.Adi = " üzüm";
            urun3.Fiyati = 20;
            urun3.Aciklama = " en iyi üzüm";
            urun3.stokAdeti = 50;
            urun3.IndirimOrani = " 40%";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};


            foreach (var urun in urunler)   // urunler dizisindeki herbir urunu "urun" olarak kodluyor ve dizi sayısı kadar döndürerek yazıyor.
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdeti);
                Console.WriteLine(urun.IndirimOrani);
                Console.WriteLine("--------------------");

            }


            Console.WriteLine("---------------Metodlar------------");


            //instance -- ornek
            // encapsulation -- düzensiz bir olayı düzene sokuyoruz
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "en iyisi", 15,10);
            sepetManager.Ekle2("elam", "en lala", 15,9);
            sepetManager.Ekle2("karpuz", "en sisisii", 15,8);
        }
    }
}

// do not repeat yourself. Clean Code