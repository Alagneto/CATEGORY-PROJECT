using System;

namespace Kategori_pROJESİ
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself
            string kategoriEtiketi = "kategori";

            int ogrenciSayısı = 13000;
            double faizoranı = 0.65;
            bool sistemeGirisYapmısMı = false;
            double dolarınBugunkuDegeri = 7.35;
            double dolarDunkuDegeri = 7.45;

            if (dolarDunkuDegeri>dolarınBugunkuDegeri)
            {
                Console.WriteLine("azalıs butonu goster");
            }
            else if (dolarDunkuDegeri<dolarınBugunkuDegeri)
            {
                Console.WriteLine("artıs butonu goster");
            }
            else
            {
                Console.WriteLine("degismedi butonu goster");
            }

            if (sistemeGirisYapmısMı==true)
            {
                Console.WriteLine("kullanıcı Ayarlar butonu ");
            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
