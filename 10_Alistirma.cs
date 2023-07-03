using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Alistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("İsminiz nedir?");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz nedir?");
            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız şehir?");
            string sehir = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İsim : " + isim); // İsim : Zeynep
            Console.WriteLine("Soyisim : " + soyisim); // Soyisim : Baydemir
            Console.WriteLine("Şehir : " + sehir);

            Console.ReadKey();
        }
    }
}
