using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Karar_Yapilari_Switch_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Kullanıcı seçimlerinde ya da tek bir değişken üzerindeki değerlere göre
			//işlem yapmak istediğimizde biraz daha sade olarak karar yapısı olarak kullanmak istediğimizde seçeriz.

			/*
			 * 
			 * switch(ifade)
			 * {
			 * case kontrol1 :
			 *  çalışacak olan işlemler
			 * break;
			 *  case kontrol2 :
			 *  çalışacak olan işlemler
			 * break;
			 * default:
			 *  çalışacak olan işlemler
			 * break;
			 * }
			 * 
			 */

			//Örnek: Kullanıcıdan bir değer al.
			//Ocak Şubat Mart Nisan...
			Console.Write("Hangi Ay :");
			string kullaniciGelen = Console.ReadLine();

			switch (kullaniciGelen)
			{
				case "Ocak":
				case "Nisan"://Birden çok case olabilir. Veya gibi düşünülebilir. Ocak veya Nisan mı gibi
                    Console.WriteLine("01");
                    break;
				case "Şubat":
					Console.WriteLine("02");
					break;
				case "Mart":
					Console.WriteLine("03");
					break;
				default:
					Console.WriteLine("Belirtilen degerlerin disinda bir deger girisi yaptiniz");
					break;
			}

			//Switch den sonra alttaki kodlar çalışır.
			Console.WriteLine("Kod1 ");
			Console.WriteLine("Kod2 ");
			

			Console.ReadLine();
		}
	}
}
