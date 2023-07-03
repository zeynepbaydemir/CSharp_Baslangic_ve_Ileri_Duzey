using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Ic_Ice_for_Dongusu_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ic ice for dongusu kullanimi
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Clear();
        }
    }
}
