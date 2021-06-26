using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ali";
            int yas = 36;

            Kurs kurs1=new Kurs();  // class degiskeni tanımlama
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "ALİ AKBAŞ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmeni = "Ahmet";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmeni = "berkay";
            kurs3.IzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi + "  " + kurs1.Egitmeni);


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };    //boyle olunca icinde klass tutulur.

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.KursAdi + " : " + Kurs.Egitmeni);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }    
        public string Egitmeni { get; set; }        //prop yazarak olusuyor.
        public int IzlenmeOrani { get; set; } 
    }




}
