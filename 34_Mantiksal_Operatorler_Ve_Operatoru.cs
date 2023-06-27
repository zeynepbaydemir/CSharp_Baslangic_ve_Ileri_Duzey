using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Mantiksal_Operatorler_Ve_Operatoru
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Mantıksal ve Operatoru -> &&
			//bool donenDeger = degisken1 && degisken2
			/* 
			 * 
			 * Degisken1    Degisken2    Sonuc
			 * True         True         True 	
			 * False        True         False 
			 * True         False        False
			 * False        False        False 
			 * 
			 */

			string ad = "zeynep";
			string sifre = "123";
			//string amahtar = "1";

			//istediğin kadar degiskeni ekleyebilirsin sonuna
			//bool donenDeger = ad == "admin" && sifre == "123" && anahtar == "1"; //False

			bool donenDeger = ad == "admin" && sifre == "123"; //False
            Console.WriteLine(donenDeger);

			Console.ReadKey();
        }
	}
}
