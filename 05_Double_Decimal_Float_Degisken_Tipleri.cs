using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Double_Decimal_Float_Degisken_Tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double
            //Double kendisinden küçük olan değeri içinde saklayabilir.
            //Double da degerin sonuna d harfi koymana gerek yok.
            double doubleVal1 = 10.2;
            double doubleVal2 = 10;
            double doubleVal3 = 10.9d;

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            //Decimal
            //Decimal değer tanımlayabilmek için sonuna M koymak gerekiyor.
            decimal decimalVal1 = 10.2M;

            decimal decimalMinVal = decimal.MinValue;
            decimal decimalMaxVal = decimal.MaxValue;


            //Float
            //Float değer tanımlayabilmek için sonuna F koymalısın. 

            float floatVal1 = 10.2F;
            
            float floatMinVal = float.MinValue;
            float floatMaxVal = float.MaxValue;
        }
    }
}
