using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_As_Operatoru_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//as Operatoru
			//fazla tercih edilmez
			string isimSoyisim = "Zeynep Baydemir";
			object objectString = isimSoyisim;
			string sonucStr = objectString as string;
		}
	}
}
