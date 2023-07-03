using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Bolum_Sonu_Alistirma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Merhaba 
            İsminiz: Zeynep
            Soyisim : Baydemir
            Şehir : Antalya
            Yaş : 35

            Ekran Temizle

            İsminiz: Zeynep
            Soyisim : Baydemir
            Şehir : Antalya
            Yaş : 35

             */

            Console.WriteLine("Merhaba");

            Console.Write("İsminiz: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisim: ");
            string soyisim = Console.ReadLine();

            Console.Write("Şehir");
            string sehir = Console.ReadLine();

            Console.Write("yaş");
            string yasStr = Console.ReadLine();
            int yasConvert = Convert.ToInt32(yasStr);
            int yasConvert2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Şehir : " + sehir);
            Console.WriteLine("Yaş :" + yasConvert);

            Console.ReadKey();
        }
    }
}
