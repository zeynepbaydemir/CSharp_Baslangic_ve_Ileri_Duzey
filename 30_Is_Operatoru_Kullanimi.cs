using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Is_Operatoru_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int s1 = 50;
			int s2 = 100;


			//object olarak tanımlanan değişken her tipteki veriyi içinde saklayabilir.
			object o1 = s1;
            Console.WriteLine(o1);
			s1 = (int)o1; //Bilincsiz tur donusumu
			///s1 = (byte)o1; //object degerin yaninda degiskenin tipini de kendi icerisinde barindirir
			//Eger sistem byte dan gediginde farkli int den geldiginde farkli davranmak istiyorsa Is operatorune basvururuz.


			//is Operatoru
			//object üzerindeki tipe gore kontrol saglar
			// bool donenDeger = degisken is degiskenTipi
			bool isKontrol1 = o1 is int;// true o1 in içerisindeki deger int mi? diye kontrol saglar
			bool isKontrol2 = o1 is byte;//false
		}
	}
}
