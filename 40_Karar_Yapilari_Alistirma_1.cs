using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Karar_Yapilari_Alistirma_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Kullanıcı adınızı giriniz : ");
			string kullaniciAdi = Console.ReadLine();

			Console.Write("Şifrenizi giriniz : ");
			string sifre = Console.ReadLine();

			//Aşağıdaki verilen koşullar doğruysa doğru kabul et
			//Kullanıcı adı : admin 
			//Şifre : 123

			if (kullaniciAdi == "admin" && sifre == "123")
			{
                Console.WriteLine("Merhaba, girişiniz başarılı");
            }
            else
            {
				Console.WriteLine("Giriş başarısız, Kullanıcı adı veya şifrenizi kontrol ediniz.");
            }
        }
	}
}
