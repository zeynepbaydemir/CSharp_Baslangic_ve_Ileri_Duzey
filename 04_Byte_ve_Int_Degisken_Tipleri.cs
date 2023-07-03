using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Byte_ve_Int_Degisken_Tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //değişken içerisinde saklayacağın değere göre veri tipi seçimi yaparsın.

            // Tamsayıları saklamak için kullanılırlar
            byte deger1 = 10; 
            int deger2 = 100;

            //byte değişken tipinin alabileceği en küçük değer
            byte byteMinVal = byte.MinValue;

            //byte değişken tipinin alabileceği en büyük değer
            byte byteMaxVal = byte.MaxValue;


            //int değişken tipinin alabileceği en küçük değer
            int intMinVal = int.MinValue;
            //int değişken tipinin alabileceği en büyük değer
            int intMaxVal = int.MaxValue;

            Console.WriteLine(byteMinVal);
            Console.WriteLine(byteMaxVal);

            Console.WriteLine(intMinVal);
            Console.WriteLine(intMaxVal);
        } 
    }
}
