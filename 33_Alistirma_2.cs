using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Alistirma_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Kullanıcı adı : admin 
			// Şifre : 123

			// Kullanıcı adınızı giriniz : 
			// Şifrenizi giriniz :

			Console.Write("Kullanıcı adınızı giriniz : ");
			string ad = Console.ReadLine();

			Console.Write("Şifrenizi giriniz : ");
			string sifre = Console.ReadLine();

			bool esitKontrolAd1 = ad == "admin";
			bool esitKontrolAd2 = ad != "admin";
            Console.WriteLine("Kullanıcı adı admin e eşit mi? " + esitKontrolAd1);
			Console.WriteLine("Kullanıcı adı admin e eşit değil mi? " + esitKontrolAd2);

			bool esitKontrolSifre1 = sifre == "123";
			bool esitKontrolSifre2 = sifre != "123";
			Console.WriteLine("Kullanıcı sifresi 123 e eşit mi? " + esitKontrolSifre1);
			Console.WriteLine("Kullanıcı sifresi 123 e eşit değil mi? " + esitKontrolSifre2);

			Console.ReadKey();

		}
	}
}
