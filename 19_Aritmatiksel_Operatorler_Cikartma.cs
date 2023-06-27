using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Aritmatiksel_Operatorler_Çıkartma
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Çıkartma Operatör ( - )
			// byte, int, double, float, decimal

			int s1 = 100;
			int s2 = 50;

			int sonuc = s1 - s2; //50
			Console.WriteLine(sonuc);

			//byte yine burada sonucu int olarak verir.
			//Byte aralığı çok küçüktür (0-255)
			//Eksili sayı çıkma olasılığı çok yüksek olduğundan direkt int tipimnde geri döner.
			byte b1 = 50;
			byte b2 = 100;
			int sonucByte = b1 - b2;

			Console.ReadKey();
		}
	}
}
