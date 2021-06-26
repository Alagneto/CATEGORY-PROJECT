using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "URUN EKLENDI");
        
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");

        }

        public int Topla(int sayi1, int sayi2)   // burada int ile yazılmasının sebebi toplamayı yapıp lazım olması halinde tekrar çağırabilinip işleme sokabilmek.
        {

            return sayi1 + sayi2;  // bu şekilde bu sonucu tekrar kullanbilirz

        }


        public void Topla2(int sayi1, int sayi2)   // void olunca fonkisyon kullanılıp bitirilir.
        {

            Console.WriteLine(sayi1 + sayi2);       // sadece ekrana yazırılır.

        }

    }
}
