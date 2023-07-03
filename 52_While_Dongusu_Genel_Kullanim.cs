using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_While_Dongusu_Genel_Kullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //While dongusu genel kullanimi


            //while (1==1) //sart true oldugu surece dongu calismasina devam eder
            //{
            /*
             * 1 - While(False) -> while icerisindeki sart false olana kadar dongu devam eder
             * 2 - Break; (Dongu icerisinde bir yerde break anahtar kelimesi kullanılırsa yine donguden cikmis oluruz.)
             * 
             */
            //}



            //Ornek kullanım 1 : Ekrana 1 - 10 a kadar sayilarin degerlerini yazdırınız.

            //for dongusu ile işlemin cozumu

            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            int sayac = 1;
            while (sayac <= 10)//while dongusu kendi şart blogu icerisinde sadece true ve false a bakar.
            {
                Console.WriteLine(sayac);
                sayac++;//yukarıdaki neden yüzünden sayac ı arttırmasını biz soyledik. 
            }

            Console.ReadKey();
        }
    }
}
