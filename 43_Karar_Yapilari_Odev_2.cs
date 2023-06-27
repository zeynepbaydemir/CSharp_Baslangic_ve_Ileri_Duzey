using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Karar_Yapilari_Odev_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /*
			 * Not ortalaması sistemine hoş geldiniz!
			 * 
			 * İsim ve soyisim: Zeynep Baydemir 
			 * Not 1 : 50
			 * Not 2 : 40
			 * Not 3 : 60
			 * 
			 * Ortalama 45 degerinden küçük ise: Kaldınız
			 * Ortalama 45 degerine eşit veya 70 degerinden küçük ise: Orta ile gectiniz
			 * Ortalama 70 degerine esit veya 90 degerinden küçük ise : İyi ile gectiniz
			 * Ortalama 90 ile 100 arasında ise (100 dahil) : Başarılı tebrikler
			 * Ortalama degeri 100 den büyük ise : Notlarınızı kontrol ediniz.
			 * 
			 */

            Console.WriteLine("Not ortalaması sistemine hoş geldiniz!");

            Console.Write("İsim ve soyisim : ");
			string isimSoyisim = Console.ReadLine();

			Console.Write("Not 1 : ");
			string notStr1 = Console.ReadLine();

            Console.Write("Not 2 : ");
            string notStr2 = Console.ReadLine();

			Console.Write("Not 3 : ");
			string notStr3 = Console.ReadLine();

			decimal not1 = Convert.ToDecimal(notStr1);
			decimal not2 = Convert.ToDecimal(notStr2);
			decimal not3 = Convert.ToDecimal(notStr3);

			//decimal toplam = not1 + not2 + not3;
			//decimal ortalama = toplam / 3;

			decimal ortalama = (not1 + not2 + not3) / 3;

			if (ortalama < 45)
			{
				Console.WriteLine("Kaldınız");
			}
			else if (ortalama >= 45 && ortalama < 70)
			{
				Console.WriteLine("Orta ile geçtiniz");
			}
			else if (ortalama >= 70 && ortalama < 90)
			{
				Console.WriteLine("İyi ile geçtiniz");
			}
			else if (ortalama >= 90 && ortalama <= 100)
			{
				Console.WriteLine("Başarılı tebrikler");
			}
			else //tek satır kod yazacaksan parantezlere gerek yok
			{
				//kod okunurlugu acisindan koysan daha iyi olur
                Console.WriteLine("Not degerlerinizi kontrol ediniz.");
            }
        }
	}
}
