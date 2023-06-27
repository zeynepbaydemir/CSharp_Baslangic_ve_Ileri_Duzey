using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Karar_Yapilari_Alistirma
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /*
			 * 
			 * Kullanıcı Kodu:
			 * 
			 * Kullanıcı Kodu = AA - BB - CC
			 *	Admin yetkisine sahipsiniz 
			 * Kullanıcı Kodu = DD
			 *  Güçlü kullanıcı yetkisine sahipsiniz
			 * Kullanıcı Kodu = FF - EE - GG
			 *	Standart kullanıcı yetkisine sahipsiniz
			 *	
			 *	Farklı bir giriş olursa : Hatalı kullanıcı kodu 
			 *	
			 */

            Console.Write("Kullanıcı kodunu giriniz : ");
			string kod = Console.ReadLine();

			switch (kod)
			{
				case "AA":
				case "BB":
				case "CC":
					Console.WriteLine("Admin yetkisine sahipsiniz");
					break;
				case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz");
					break;
				case "FF":
				case "EE":
				case "GG":
					Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz");
					break;
				default:
					Console.WriteLine("Hatalı kullanıcı kodu");
					break;
            }

			Console.ReadLine();
        }
	}
}
