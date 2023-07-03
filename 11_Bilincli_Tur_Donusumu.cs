using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Bilincli_Tur_Donusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilinçli Tür Dönüşümü : 
            //Bu işlem genellikle daha büyük bir veri türünden daha küçük bir
            //veri türüne dönüşüm yaparken kullanılır ve veri kaybına neden olabilir. 
            //
            byte sayi1 = 100; //true
            byte byteMin = byte.MinValue; //byte min değer görürsün 0 
            byte byteMax = byte.MaxValue; //byte max değer görürsün 255
            // sayi1 = 256 -> hata verir.

            int sayi2 = 256;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            //degisken tipi byte olan bi degiskenin icerisindeki degeri integer a atarak verildi
            //Türler arası geçiş oldu 
            int sayi3 = sayi1;  //bilinçli tür dönüşümü 

        }
    }
}
