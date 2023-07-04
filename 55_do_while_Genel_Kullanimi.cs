using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_do_while_Genel_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do while dongulerindeki en temel fark sartlari ne olursa olsun bir kere kesin çalışır

            do
            {
                //do while şart ne olursa olsun mutlaka bir kere çalışır
                Console.WriteLine("Merhaba do while");
            } while (1 == 2);
            {
                //şart dogru degil bu döngüye hiç girmez ama do while döngüsündeki do
                //kısmında varilen şeyi mutlaka bir kez yazdırır
            }

            
        }
    }
}
