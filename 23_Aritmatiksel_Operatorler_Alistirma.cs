using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Aritmatiksel_Operatorler_Alistirma
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /*
			 Merhaba
			İsminiz : 
			Soyisminiz :
			Doğum Yılınız : 

			Ekranı Temizle

			Merhaba Zeynep Baydemir 20 yaşındasınız...
			 */

            Console.WriteLine("Merhaba");
            Console.Write("İsminiz :");
			string isim = Console.ReadLine();

            Console.Write("Soyisminiz :");
			string soyisim = Console.ReadLine();

			Console.Write("Dogum Yılınız :");
			string dogumTarihi = Console.ReadLine();

			Console.Clear();

			int dt = Convert.ToInt32(dogumTarihi);
			//int suAnYil = 2023;
			int suAnYil = DateTime.Now.Year;
			int yas = suAnYil - dt;

			string mesaj = "Merhaba " + isim + " " + soyisim + " " + yas + " yasindasiniz...";
			Console.WriteLine(mesaj);

			Console.ReadLine();
        }
	}
}
