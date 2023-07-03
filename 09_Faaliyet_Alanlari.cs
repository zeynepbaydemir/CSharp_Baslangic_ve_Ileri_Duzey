using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Faaliyet_Alanlari
{
    internal class Program
    {
        //Oluşturmuş olduğumuz değerler bir alan içide kısıtlıdır. 

        static string S2 = "Frodo Baggins";
        static void Main(string[] args)
        {
            //bir değşken oluşturduğumuzda değişkenin kullanılabileceği sınırlar vardır. 

            string S1 = "Zeynep Baydemir";
            S1 = "İkinci isim";

            S2 = "Bir Alt";
        }

        static void Test() 
        {
            S2 = "İkinci Değer";
        }
    }
}
