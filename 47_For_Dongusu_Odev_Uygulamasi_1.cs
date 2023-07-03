using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_For_Dongusu_Odev_Uygulamasi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kullanici ekran uzerinden bir sayi girisi yapacak
             * Girilen sayinin faktoriyel hesabini alip ekrana yazdiralim.
            */

            string kullaniciGelenDeger = string.Empty;
            int kullaniciGelenDegerInt = 0;
            int faktoriyelHesapla = 0;

            Console.WriteLine("Lütfen faktoriyel hesabi yapmak istediğiniz degeri ekrana giriniz: ");
            kullaniciGelenDeger = Console.ReadLine();
            kullaniciGelenDegerInt = int.Parse(kullaniciGelenDeger);

            for (int i = kullaniciGelenDegerInt; i>1; i--)
            {
                //aşağıda verilen iki ifade de ayni islemi gerceklestirir. 
                faktoriyelHesapla = faktoriyelHesapla * i;
                //faktoriyelHesapla *= i;
            }

            Console.WriteLine("{0} degerinin faktoriyel sonucu : {1}", kullaniciGelenDeger, faktoriyelHesapla);

        }
    }
}
