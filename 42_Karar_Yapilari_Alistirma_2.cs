using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Karar_Yapilari_Alistirma_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * 
			 * Menü
			 * 1 - Toplama
			 * 2 - Çıkartma
			 * 3 - Çarpma
			 * 4 - Bölme
			 * Seçiniz : _
			 * 
			 * Kurallar : 4.seçenek içerisinde bölen 0 olamaz kontrolü yapılacak
			 * 
			 */

			Console.WriteLine("Menü");
			Console.WriteLine("1 - Toplama");
			Console.WriteLine("2 - Çıkartma");
			Console.WriteLine("3 - Çarpma");
			Console.WriteLine("4 - Bölme");
			Console.Write("Seçiniz : ");
			string kullaniciSecim = Console.ReadLine();

			//local degiskenler(double, int) deger almadan calisamazlar
			//default olarak 0 atadık.
			double sayi1=0;
			double sayi2=0;

			//kullanıcı seceneklerde olmayan bir sayıyı secerse diye bunu koyduk.
			if (kullaniciSecim == "1" || kullaniciSecim == "2" || kullaniciSecim == "3" || kullaniciSecim == "4")
			{
				Console.Write("Sayı 1 degerini giriniz : ");
				string s1 = Console.ReadLine();

				Console.Write("Sayı 2 degerini giriniz : ");
				string s2 = Console.ReadLine();

				sayi1 = Convert.ToDouble(s1);
				sayi2 = Convert.ToDouble(s2);
			}



			if (kullaniciSecim == "1")
			{
				double toplam = sayi1 + sayi2;
				Console.WriteLine("Toplam : " + toplam);
			}
			else if (kullaniciSecim == "2")
			{
				double cikartma = sayi1 - sayi2;
				Console.WriteLine("Çıkartma : " + cikartma);
			}
			else if (kullaniciSecim == "3")
			{
				double carpma = sayi1 * sayi2;
				Console.WriteLine("Çarpma : " + carpma);
			}
			else if (kullaniciSecim == "4")
			{
				if (sayi2 == 0)
				{
					Console.WriteLine("Bölen deger 0 olamaz");
				}
				else
				{
					double bolum = sayi2 / sayi1;
					Console.WriteLine("Kalan : " + bolum);
				}
			}
			else
			{
				Console.WriteLine("Seçim dışı deger girisi yaptınız.");
			}

			Console.WriteLine("Uygulama Sonu");

			Console.ReadLine();
		}
	}
}
