using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>   // T verilen tip oluyor
    {

        T[] items;
        //constructor

        public MyList()    // ctror tab tab  // Class başlangıcında ilk kez çalışacak olan
        {

            items = new T[0];
        }

        public void Add(T item)     // kullanılacak tipe göre item ver
        {
            T[] tempArray = items;   // yeni dizi referansı tanımladıgımızda eskisi kaybolmasın diye bu şekilde tempArray olarak yedekledik.
            items = new T[items.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // kayıt edilen degerleri sırasıyle items  geri alıyoruz.
            }

            items[items.Length - 1] = item;
        }


    }
}
