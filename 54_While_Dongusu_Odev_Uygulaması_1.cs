using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_While_Dongusu_Odev_Uygulaması_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Odev: Sistemin calisma zamaninda olusturdugu 1 ile 10 arasındaki
             * bir degeri kullanicinin tahmin etmesini isteyecek bir uygulama yazalım
             */

            int sistemUretSayi = 0;
            int tahminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1,10);

            //Kullanıcı üretilen sayıyı bulana kadar yeni sayı girsin
            //Üretilen sayıyı kullanıcı tahmin edebildiyse döngüden çıkın
            //Kullanıcı başarılı olursa şu kadar deneme yaptınız başarılı oldunuz vs tarzında bi yazı gelsin

            while (true)
            {
                Console.Write("{0} . deneme - Lütfen sistemin üretmiş olduğu sayiyi tahmin ediniz : ", tahminAdet);
                string rndKullaniciGelen = Console.ReadLine();

                if (Convert.ToInt32(rndKullaniciGelen) == sistemUretSayi)
                {
                    tahminAdet++;
                    Console.WriteLine("Tebrikler! Tahmin ettiniz!");
                    break;
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Tahmin edemediniz lütfen yeniden deneyin...",tahminAdet);
                    tahminAdet++;
                }
            }

            Console.WriteLine("Sistemin bulundugu deger : {0}", sistemUretSayi);

            Console.ReadKey();
        }
    }
}
