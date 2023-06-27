using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Karar_Yapilari_if_ve_else_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * 
			 * if(şart veya şartlar)
			 * {
			 * //  şart veya şartlar doğru ise o zaman çalışacak kodlar
			 * }
			 * else
			 * {
			 * şart veya şartlar dogru degil ise o zaman calisacak olan kodlar
			 * }
			 * 
			 */

			Console.Write("Sayi 1 degerini giriniz : ");
			string sStr1 = Console.ReadLine();

			Console.Write("Sayı 2 degerini giriniz : ");
			string sStr2 = Console.ReadLine();

			decimal sayi1 = Convert.ToDecimal(sStr1);
			decimal sayi2 = Convert.ToDecimal(sStr2);
			decimal toplam = sayi1 + sayi2;

			if (toplam > 50)
			{
				Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");
			}
			else 
			{
				Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den küçük...");
			}

			//Altında herhangi başka bir kod varsa onu da çalıştırır ve program sonlandırılır.

			Console.WriteLine("Kod1");
			Console.WriteLine("Kod2");
		}
	}
}
