using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Ic_Ice_For_Dongusu_Kullanimi_Odev_Uygulamasi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Odev : Carpim Tablosu

            /*
             * 1*1=1
             * 1*2=2
             * 1*3=3
             * .
             * .
             * 1*10=10
             * 
             * 2*1=2
             */

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int carpim = i * j;
                    Console.Write("{0}*{1}={2}\t",i,j,carpim);//Console.Write ile carpim tablosunun konsolda yan yana görünmesini sağladık.
                }
                Console.WriteLine(); //araya bosluk atar
            }

            //Console.Clear();

            Console.ReadKey();
        }
    }
}
