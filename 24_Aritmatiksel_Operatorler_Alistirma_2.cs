using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Aritmatik_Operatorler_Alistirma_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /*
			Sayı 1 degerini giriniz:
			Sayı 2 degerini giriniz:
			
			+ :
			- : 
			/ :
			* :
			% :

			 */

            Console.Write("Sayı 1 degerini giriniz: ");
			decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

			Console.Write("Sayı 2 degerini giriniz: ");
			decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

			decimal topla = sayi1 + sayi2;
			decimal cikarma = sayi1 - sayi2;
			decimal bolme = sayi1 / sayi2;
			decimal carpma = sayi1 * sayi2;
			decimal mod = sayi1 % sayi2;

            Console.WriteLine("+ :" + topla);
			Console.WriteLine("- :" + cikarma);
			Console.WriteLine("/ :" + bolme);
			Console.WriteLine("* :" +  carpma);
            Console.WriteLine("% :" + mod);

			Console.ReadLine();
        }
	}
}
