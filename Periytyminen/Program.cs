using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Periytyminen
{
	class Program
	{
		static void Main(string[] args)
		{


			Kissa elukka1 = new Kissa();
			elukka1.AsetaElaimenIka(2);
			elukka1.AsetaElaimenNimi("kisuli");
			elukka1.AsetaOnLihanSyoja(true);
			elukka1.Kehrää();

			Koira elukka2 = new Koira();
			elukka2.AsetaElaimenNimi("Musti");
			elukka2.AsetaElaimenIka(1);
			elukka2.AsetaOnLihanSyoja(true);
			elukka2.ääntele();
			elukka1.ääntele();
			


			Linnut Papukaija1 = new Linnut();
			Papukaija1.AsetaElaimenIka(4);
			Papukaija1.AsetaElaimenNimi("Pele");

			Koira dog1 = new Koira();
			dog1.AsetaElaimenIka(11);
			dog1.AsetaElaimenNimi("Taku");


			Console.ReadKey();
		}
	}
}
