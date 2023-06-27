using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Aritmatiksel_Operatorler_Carpma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// *
			// byte, int, double, float, decimal

			double d1 = 10.4;
			double d2 = 10.6;
			double sonuc = d1 * d2; //110.24

			double sonucDouble = d1 * d2;
			int sonucInt = (int)sonucDouble; //sonucInt = 110 (deger kaybi yasandi)

			//tür dönüşümü yaptık
			//Çarpanın sonucu int e çevirdik aslında
			//çarpanın kendisini çevirmiyoruz. 
			//Çarptıktan sonra çeviriyoruz
			//Parantezin disina cıkan degeri int e ceviriyoruz.
			sonucInt = (int)(d1 * d2);
		}
	}
}
