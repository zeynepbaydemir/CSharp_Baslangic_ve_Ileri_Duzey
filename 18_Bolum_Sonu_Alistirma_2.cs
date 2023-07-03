using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Bolum_Sonu_Alistirma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru 1: String olarak verilen degeri bool tipine dönüstürün
            string metin1 = "True";
            bool sb1 = bool.Parse(metin1);
            bool sb2 = Convert.ToBoolean(metin1);

            //Soru 2: int icerisinde olan 100 degerini byte ve float degisken tiplerine
            //donusturun
            int s1 = 100;
            byte byteDegisken = (byte) s1;
            float floatDegisken = s1; //float daha büyük bir degisken oldugu icin sorun cikmadi.  

            //Soru 3: Byte degisken icerisinde olan tipi Decimal degisken tipine donusturun.
            byte b1 = 10;
            decimal d1 = b1;   
        }
    }
}
