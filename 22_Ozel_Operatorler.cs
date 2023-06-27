using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Ozel_Operatorler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Mod alma operatörü %
			int s1 = 10;
			int s2 = 2;
			int sonucMod = s1 % 2; //0 -> 2 ye tam bölündü.
								   //kalan 2 ye bölünemeyene kadar 10 u 2 ye böldü.

			int s3 = 11;
			int s4 = 2;
			int sonucMod1 = s3 % s4; // sonucMod1 = 1 oldu



			// ++ operatörü
			// Artının yerine göre davranış değişir.

			int s5 = 10;
			int OperatorSonuc1 = s5++; // 11 -> İlk deger atar sonra deger gunceller. 
			//int OperatorSonuc1 = s5 + 1; -> uzun hali budur.) 
			int OperatorSonuc2 = ++s5; // 11 -> Artılar eğer sol taraftaysa degerleri toplar. Topladıktan sonra atama islemi yapar.

			//-- operatoru

			int s6 = 10;
			int OperatorSonuc3 = s6--; //9
			int OperatorSonuc4 = --s6; //9
		}
	}
}
