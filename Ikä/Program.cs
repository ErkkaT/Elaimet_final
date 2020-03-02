using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Ikä
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();

			int KoiranIka = rnd.Next(1, 16);
			/*
			for (int i = 1; i < 11; i++)
			{ 
				//luo loopin sisällä uusi kissa ja koira olio
				Kissa KissaLoop = new Kissa(rnd);
				int KissanIka = rnd.Next(1, 11);
				KissaLoop.AsetaKissanIka(KissanIka);

				Console.WriteLine(KissaLoop.PalautaKissanNimi() + " " + KissaLoop.PalautaKissanIka());

			}
			*/

			Console.ReadKey();
		}
	}
}
