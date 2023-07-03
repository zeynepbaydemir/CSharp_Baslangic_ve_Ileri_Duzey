using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_For_Dongusu_Ornek_Uygulama_Serisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For dongusu genel kullanimi
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ben bir for dongusuyum");
            }

            Console.Clear();

            //Ekran uzerinde 1 - 10 arasindaki degerleri yazdiralim.

            for (int i =1; i<=10; i++) 
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //1 ile 100 arasindaki çift sayıları ekran uzerinde yazdiralim.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }



            //Küçük odev : 1 - 100 arasindaki çift sayilarin toplami nedir?


            //toplam ı for dongusunun icinde tanimlamadik cunku for dongusu bitse de erismek istiyoruz.
            int toplam = 0;
            //i yerine sayac da yazabilirsin herhangi başka bir şey de
            //mesela bu ornekte sayac yazalim.
            for (int sayac = 1; sayac <= 100; sayac++)
            {
                if (sayac % 2 == 0) 
                {
                    //aşağıdaki iki kod da aynı şeyi temsil eder.
                    //toplam = toplam + sayac;
                    toplam += sayac; 
                    Console.WriteLine(toplam);
                }
            }
            // {0} -> index vererek kullandik.
            Console.WriteLine("1 ile 100 arasindaki çift sayilarin toplami: {0}", toplam);

            Console.ReadKey();
        }
    }
}
