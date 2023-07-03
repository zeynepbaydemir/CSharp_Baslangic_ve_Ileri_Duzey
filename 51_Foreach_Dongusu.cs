using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi olusturalim
            string[] Isimler = new[] {"Harry Potter", "Orumcek Adam", "Demir Adam", "Peter Pan"};

            
            foreach (string item in Isimler)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
