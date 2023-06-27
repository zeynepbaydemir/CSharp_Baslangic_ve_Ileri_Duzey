using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Aritmatiksel_Operatorler_Toplama
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Toplama Operatörü
			// + 
			//int + int (Toplama işlemi yapar)

			int s1 = 10;
			int s2 = 15;
			int toplam = s1 + s2;

			//iki byte sonucu dönen değer int halinde döner.
			//byte 0 ve 255 arasında değerler alabildiği için direkt sonucu int verir. Çünkü byte sayısal sınırını(0-255) geçmek çok kolaydır.
			byte s3 = 10;
			byte s4 = 10;
			var toplamByte = s3 + s4;

			//string + int (string)

			string metin1 = "Merhaba ";
			int s5 = 10; //s5 i string gibi görür.
			string toplamStr1 = metin1 + s5;  //Merhaba 10
											  //toplama operatörü aslında string birleştirme işlemi yapar.

			//int + string (string)

			string toplamStr2 = s5 + metin1; //10Merhaba


			//string + string (string)
			//direkt string birlestirme yapar

			string metin2 = " Dünya";
			string toplamStr3 = metin1 + metin2; // Merhaba Dünya

		}
	}
}
