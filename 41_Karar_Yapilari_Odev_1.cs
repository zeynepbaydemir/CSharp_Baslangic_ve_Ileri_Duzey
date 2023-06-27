using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Karar_Yapilari_Odev_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Sistem içerisinde giriş yapabilecek kullanıcı kodları
			 * 
			 * ABC - 123 - 236 - CMK
			 * Kullanıcı girişiniz başarılı
			 * 
			 * Sistem içerisine girişi yasaklanmış kullanıcı kodları
			 * 
			 * HHH - BBB - MMM
			 * 
			 * Kullanıcı girişiniz kilitlenmiştir.
			 * 
			 * Bunların dışında ise,
			 * 
			 * Hatalı kullanıcı kodu
			 */

			Console.WriteLine("Giriş Kodu: ");
			string kod = Console.ReadLine();

			kod = kod.ToUpper();//Hepsini büyük harfe çevir

            if (kod == "ABC" || kod == "123" || kod == "236" || kod == "CMK")
            {
                Console.WriteLine("Kullanıcı girişi başarılı.");
            }
			else if(kod == "HHH" || kod == "BBB" || kod == "MMM")
			{
				Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
			}
            else
            {
				Console.WriteLine("Hatalı kullanıcı kodu");
            }

        }
	}
}
