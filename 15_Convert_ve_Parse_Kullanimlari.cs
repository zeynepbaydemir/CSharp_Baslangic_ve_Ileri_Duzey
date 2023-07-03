using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_ve_Parse_Kullanimlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Dönüşümü
            //String gelen bir değeri int e ya da decimal e ya da diğer değişken tiplerine nasıl çeviririm?

            string metin1 = "100";

            int s1 = int.Parse(metin1);
            int s2 = Convert.ToInt32(metin1);

            string metin2 = "True";
            bool b1 = bool.Parse(metin2);
            bool b2 = Convert.ToBoolean(metin2);

            //String içerisindeki null degerini decimal e cevirmek istiyoruz.
            //null: Programsal olarak icerisinde herhnagi bir değer barındırmaz anlamına gelir
            string metin3 = null;

            decimal d1 = decimal.Parse(metin3); //null hatası verir
            decimal d2 = Convert.ToDecimal(metin3); //Hata vermez. Default degeri orada bırakır.

            bool b3 = Convert.ToBoolean(metin3);
        }
    }
}
