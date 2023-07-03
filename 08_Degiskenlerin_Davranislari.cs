using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Degiskenlerin_Davranislari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degiskenVal1 = "Zeynep Baydemir";
            string degiskenVal2 = "Harry Potter";

            degiskenVal1 = degiskenVal2;

            degiskenVal2 = "Frodo Baggins";
        }
    }
}
