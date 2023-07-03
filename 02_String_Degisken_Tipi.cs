using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Degisken_Tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String tipi

            string isimSoyisim = "Zeynep Baydemir";

            Console.WriteLine(isimSoyisim);

            isimSoyisim = "Frodo Baggins";

            Console.WriteLine(isimSoyisim);

            //Tüm metni büyük harfle yaz
            string buyukKarakter = isimSoyisim.ToUpper();
            //Tüm metni küçük harfle yaz
            string kucukKarakter = isimSoyisim.ToLower();

            //Verilen değerler arası metni al
            string belirliBirBolum = isimSoyisim.Substring(2, 4);
        }
    }
}
