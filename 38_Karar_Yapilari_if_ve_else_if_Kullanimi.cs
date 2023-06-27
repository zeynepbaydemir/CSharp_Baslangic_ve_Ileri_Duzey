using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Karar_Yapilari_if_ve_else_if_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * if()
			 * {
			 *  //şart veya şartlar dogru ise o zaman çalışacak kodlar
			 * }
			 * else if(şart veya şartlar)
			 * {}
			 * else if(şart veya şartlar)
			 * {}
			 * else if(şart veya şartlar)
			 * {}
			 * else
			 * {
			 *  //şart veya şartlar doğru değil ise o zaman çalışacak olan kodlar
			 * }
			 * 
			 */

			/*
			 * Girilen degerlerin toplamı 100 den büyükse ekrana 100 den büyük yazalım
			 * 50 den büyükse 50 den büyük yazalım.
			 * 50 den küçükse girilen değerler 50 den küçük yazalım.
			 */

			Console.Write("Sayı 1 degerini giriniz : ");
			string sStr1 = Console.ReadLine();

			Console.Write("Sayı 2 degerini giriniz : ");
			string sStr2 = Console.ReadLine();

			decimal sayi1 = Convert.ToDecimal(sStr1);
			decimal sayi2 = Convert.ToDecimal(sStr2);
			decimal toplam = sayi1 + sayi2;

			if (toplam >= 100)
			{
                Console.WriteLine("Girilen deger 100 eşit veya büyük");
            }
			else if (toplam >= 50) 
			{
				Console.WriteLine("Girilen deger 50 eşit veya büyük büyük");
			}
            else
            {
                Console.WriteLine("Girilen deger 50 den küçük");
            }


			//karar yapılarından çıktıktan sonra ekrana alttakileri yazdırır.
            Console.WriteLine("Kod1");
			Console.WriteLine("Kod2");
        }
	}
}
