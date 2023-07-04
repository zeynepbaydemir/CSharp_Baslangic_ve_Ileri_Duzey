using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_While_Dongusu_Ornek_Uygulama_Serisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullancidan gelen sayisal degere gore ekrana  
            //1 eksilterek 0 degerine ulasıncaya kadar ekrana yazalım.

            /*
             * 3
             * 2
             * 1
             * 0
             */

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //string kullanicidanGelenDeger = Console.ReadLine();
            //Console.WriteLine("--------------------------------------");
            //int ornekkullanimSayac = Convert.ToInt32(kullanicidanGelenDeger);

            //while (ornekkullanimSayac != -1) {
            //    Console.WriteLine(ornekkullanimSayac);
            //    ornekkullanimSayac = ornekkullanimSayac - 1;
            //    //ornekkullanimSayac--;
            //}

            //Console.WriteLine("Örnek 1 işlemi tamamlandı.");


            /*
             * Kullancidan gelen degerlerin toplamını ekrana yazdıralim.
             * 0 dan kücük bir deger girisi yapilirsa toplama islemini bitirelim
             * ve ekrana toplam sonucu yazalim
             */


            Console.WriteLine("Lütfen toplamak istediğiniz sayilari giriniz. ");
            Console.WriteLine("-1 degeri islemlerinizi durdurur.");

            int ornekKullanimToplam = 0;
            while (true)
            {
                string Ornek2KullaniciGelenDeger = Console.ReadLine();
                int Ornek2KulGelenDegerInt = Convert.ToInt32(Ornek2KullaniciGelenDeger);
                if (Ornek2KulGelenDegerInt < 0)
                    break;
                else
                    ornekKullanimToplam = ornekKullanimToplam + Ornek2KulGelenDegerInt;
            }

            Console.WriteLine("Toplam deger : {0}", ornekKullanimToplam);

            Console.ReadKey();

        }
    }
}
