using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_do_While_Dongusu_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Odev 1 : Kullaniciyi do while icerisine alin ve kullanici adi ve password sorun
             * Kullanici adi = Demo
             * Sifre = Demo
             * Eger kullanici bu degerleri bilirse döngüden çıkın ve başarılı yazın.
             * Eger yanlis giris yapiyorsa do while ile ilgili degerleri sormaya devam edin
             * 
             * 
             * Odev 2 : Kullanicidan 1 ile X arasında bir sayi girmesini isteyin.
             * Daha sonra sistem kullanicinin girmiş olduğu 1 ile X degerleri arasında bir sayı tahmini yapsın.
             * Daha sonra kullanici sistemin tahmin etmiş olduğu sayıyı bulmaya calissin
             * Bulamazsa yeniden sorsun. 
             * Kullanıcı değeri bulduğunda Y kadar denediniz ve sonuca ulastiniz desin.
             */

            //Odev 1

            //string ad = string.Empty;
            //string sifre = string.Empty;
            //int sayac = 0;

            //do
            //{
            //    if (sayac > 0)
            //    {
            //        Console.WriteLine("Kullanıcı adı ve şifre degerlerinizden biri hatalı");
            //    }
            //    Console.Write("Kullanıcı adını giriniz : ");
            //    ad = Console.ReadLine();

            //    Console.Write("Şifre girişi yapınız : ");
            //    sifre = Console.ReadLine();

            //    sayac++;

            //} while (ad.ToLower() != "demo" || sifre.ToLower() != "demo");
            //Console.WriteLine("Başarılı kullanıcı girişi");


            //Odev 2 

            int odev2tahmin = 0;
            int odev2uretilenSayi = 0;
            int odev2sayac = 0;

            Console.WriteLine("Tahmin oyunu için en yüksek degeri giriniz");
            int odev2kullaniciMaxValue = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            odev2uretilenSayi = rnd.Next(1, odev2kullaniciMaxValue);

            do
            {
                odev2sayac++;
                Console.WriteLine("{0}. hakkınız üretilen sayıyı tahmin ediniz", odev2sayac);
                odev2tahmin = Convert.ToInt32(Console.ReadLine());

            } while (odev2tahmin != odev2uretilenSayi);
            Console.WriteLine("{0}. kere denediniz sayıyı tahmin ettiniz", odev2tahmin);
        }
    }
}
