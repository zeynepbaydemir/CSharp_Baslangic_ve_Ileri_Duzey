using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Alistirma_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /*
			 Kullanıcıdan gelen 3 farklı sinav notunun ortalaması 45 degerine esit veya büyük
			mü olarak kontrol edelim. 
			 */

            Console.Write("1.sınav notunu giriniz : ");
			string not1 = Console.ReadLine();

			Console.Write("2.sınav notunu giriniz : ");
			string not2 = Console.ReadLine();
			 
			Console.Write("3.sınav notunu giriniz : ");
			string not3 = Console.ReadLine();

			decimal ort = (Convert.ToDecimal(not1 + not2 + not3)) / 3;

			bool buyukEsit = ort >= 45;
            Console.WriteLine("Ortalama degeriniz 45 degerinden büyük veya esit mi: " + buyukEsit);


			Console.ReadKey();
        }
	}
}
