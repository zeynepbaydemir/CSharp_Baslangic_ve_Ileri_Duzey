using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_For_Dongusu_Sonsuz_Dongu_Yapilmasi_Break_Continue_Anahtar_Kelimeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sonsuz dongu oluşturmak
            int sonsuzDonguSayac = 0;
            for (; ; )//bu şekilde for kullanımı sonsuz döngü anlamındadir
            {
                sonsuzDonguSayac++;
                //break anahtar kelimesi;
                //if (sonsuzDonguSayac == 2)
                //    break; //dongüyü kırar ve kodu altta devam ettirir. 
                //yukarıda sayac == 2 ise donguyu kıracak.


                //continue anahtar kelimesi
                //Continue komutu döngüde bir sonraki adıma geçmek için kullanılan komut'tur. 
                if (sonsuzDonguSayac == 2)
                    continue;

                    Console.WriteLine(sonsuzDonguSayac);

                Console.WriteLine("Merhaba ben bir sonsuz donguyum");

                Console.ReadKey();
            }
        }
    }
}
