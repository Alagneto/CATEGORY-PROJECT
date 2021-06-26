using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici yetistirme kampı";
            string kurs2 = "programlamaya baslangıc kursu";
            string kurs3 = "Java";

            // array -dizi

            string[] kurslar = new string[] { "Yazılım Gelistirici yetistirme kampı", "programlamaya baslangıc kursu" , "Java" ,"css","python"};



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)   // dizileri tanımlamak icin genelde bu tercih edilir.
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu");
        }
    }
}
