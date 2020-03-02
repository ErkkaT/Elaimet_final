using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
	public class Linnut : Elain
	{
		public bool paikannin;

		public Linnut()
		{
			ika = 0;
			nimi = "Siipiveikko";
		}
		//vertaa tätä aseta lihansyöjään, miksi tässä on return??
		public bool AsetaOnkoPaikannin(bool jalkapaikannin)
		{
			paikannin = jalkapaikannin;
			return paikannin; //miksi pitää olla tämä?
		}

		public bool PalautaOnkoPaikannin()
		{

			if (paikannin == true)
			{
				Console.Write(" Minulla on paikannin.");
			}
			else
			{
				Console.Write(" Ei ole paikanninta.");
			}
			return paikannin;
		}

		public Linnut(int age, string name) : base(age, name)
		{
			ika = age;
			nimi = name;
		}

		
		public override void ääntele()
		{
			//Muunnetaan Umph! linnun omaksi ääneksi
			{
				Console.WriteLine("Skviik!");
			}
		}

	}
}
	