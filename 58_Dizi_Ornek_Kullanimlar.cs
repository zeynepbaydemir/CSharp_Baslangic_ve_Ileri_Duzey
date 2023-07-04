using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Dizi_Ornek_Kullanimlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ornek Uygulamalar
             * Uygulama 1 : Int veri tipinde bir dizi olusturalim, kullanicimiz
             * dizinin kac elemanlı olacagı bilgisini bize versin ve dizi icindeki alanlara 
             * deger atamasi yapsin. Daha sonra dizi icerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran 
             * bir uygulama yazalım
             * 
             */

            //Console.WriteLine("Lütfen olusturmak istediğiniz veri kümesinin uzunluğunu giriniz");
            //string uygulamaDiziUzunluk = Console.ReadLine();
            //int uygulamaDiziUzunlukInt = Convert.ToInt32(uygulamaDiziUzunluk);


            //int[] uygulamaDizi = new int[uygulamaDiziUzunlukInt];

            //for (int uygulamaSayac = 0; uygulamaSayac < uygulamaDizi.Length; uygulamaSayac++)
            //{
            //    Console.WriteLine("{0}. index e denk gelen degeri giriniz", uygulamaSayac);

            //    uygulamaDizi[uygulamaSayac] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Tebrikler dizinin içindeki tüm alanları doldurdunuz");

            //Console.WriteLine("Dizi icerisindeki degerler ve toplam, ortalama degeri asagidaki gibidir");

            //int uygulama1Toplam = 0, uygulama1Ortalama = 0;
            //foreach (int item in uygulamaDizi)
            //{
            //    Console.WriteLine(item);
            //    uygulama1Toplam = uygulama1Toplam + item;
            //}
            //Console.WriteLine("------------------------------------");

            //Console.WriteLine(uygulama1Toplam);

            //Console.WriteLine("Dizi icerisindeki eleman sayısı : {0}", uygulamaDizi.Length);
            //uygulama1Ortalama = uygulama1Toplam / uygulamaDizi.Length;
            //Console.WriteLine("Ortalama: {0}", uygulama1Ortalama);


            //Uygulama 2

            /*
             * 20 elemanlı bir int dizi olusturalim. 
             * Degerlerinizi random sınıfının next fonksiyonu ile 1-10 arasindaki degerler ile dolduralım.
             * Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde
             * kaç tane 4 degeri oldugunu bulalım.
             */

            Random rnd = new Random();

            int[] uygulama2Dizi = new int[20];
            for (int uygulama2Sayac = 0; uygulama2Sayac < uygulama2Dizi.Length; uygulama2Sayac++)
            {
                uygulama2Dizi[uygulama2Sayac] = rnd.Next(1, 10);
            }

            int uygulama2Bul = 0;

            foreach (var item in uygulama2Dizi)
            {
                Console.WriteLine(item);
                if (item == 4)
                {
                    uygulama2Bul++;
                }
            }

            Console.WriteLine("Dizi içindeki 4 degeri {0} adettir", uygulama2Bul);

            Console.ReadKey();
        }

    }
}
