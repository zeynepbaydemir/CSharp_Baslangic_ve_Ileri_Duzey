using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Mantiksal_Operatorler_Veya_Operatoru
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Veya Mantiksal Operatörü -> ||
			//Bir tanesinin True olması yetiyor.
			//İçerideki herhangi bir şarttan bi tanesi doğruysa True döner.
			//Hepsi yanlışsa false döner.
			/*
			 * Şart1     Şart2     Sonuc
			 * T         T         T
			 * F         T         T
			 * T         F         T
			 * F         F         F
			 */

			string anahtar = "FGSDFGVF";

			bool geriDonus = anahtar == "543645YTGETRGDFGV" || anahtar == "FGSDGFDG" || anahtar == "REEFG5RTWRG"; //False
            Console.WriteLine(geriDonus);

			Console.ReadKey();
        }
	}
}
