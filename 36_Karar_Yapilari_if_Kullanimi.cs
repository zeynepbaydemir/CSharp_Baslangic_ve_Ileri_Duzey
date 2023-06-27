using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Karar_Yapilari_if_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * if(sart/sartlar(&& ||))
			 * {
			 *		//Eger sart veya sartlar saglandi ise yapilacak islemler
			 * }
			 */



			/*
			 * 		Kullanıcıdan iki sayı al
			 * 		İki sayının toplamı 50 den büyükse, 50 den büyük yazdır.
			 */


			Console.Write("Sayı 1 degerini giriniz : ");
			string sStr1 = Console.ReadLine();

			Console.Write("Sayı 2 degerini giriniz : ");
			string sStr2 = Console.ReadLine();

			decimal sayi1 = Convert.ToDecimal(sStr1);
			decimal sayi2 = Convert.ToDecimal(sStr2);
			decimal toplam = sayi1 + sayi2;

			// bool toplamKontrol = toplam > 50;

			//if (toplamKontrol)
			//{
			//    Console.WriteLine("Girmis oldugunuz degerlerin toplamı 50 den buyuk");
			//}

			if (toplam > 50) 
			{
                Console.WriteLine("Girmis oldugunuz degerlerin toplami 50 den buyuk");
            }

        }
	}
}
