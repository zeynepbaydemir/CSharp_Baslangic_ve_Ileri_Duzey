using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Dizi_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            //Nasil deger ekleyebiliriz
            //1 2 3 4 ... 10
            //0 1 2 3 4 5 6 7 8 9 10

            /*
             * 5 elemanlı bir dizi olusturdugum zaman 
             * 
             * [0]
             * [1]
             */

            ogrenciIsimListesi[0] = "Cengiz Atilla";
            ogrenciIsimListesi[1] = "Ahmet Yavuz";
            ogrenciIsimListesi[2] = "Tinker Bell";
            ogrenciIsimListesi[3] = "Harry Potter";
            ogrenciIsimListesi[4] = "Pater Pan";

            //Console.WriteLine(ogrenciIsimListesi[1]);

            //olusturmus oldugumuz dizimizin icerisindeki elemanları ekrana yazdıralım.

            foreach (string item in ogrenciIsimListesi) 
            {
                Console.WriteLine(item + " bu bir foreach dongusudur");
            }

            Console.WriteLine("");//bu satır consoleda bosluk olsun diye koyuldu.

            for (int i = 0; i < ogrenciIsimListesi.Length; i++)
            {
                string gelenIsim = ogrenciIsimListesi[i];
                Console.WriteLine(gelenIsim);
            }

            Console.ReadKey();
        }
    }
}
