using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
	public class Nisakkaat : Elain
	{
		public bool turkki;

		public bool AsetaOnkoTurkki(bool Turkki)
		{
			turkki = Turkki;
			return turkki;
		}

		public bool PalautaOnkoTurkki()
		{

			if (turkki == true)
			{
				Console.Write(" Minulla on turkki.");
			}
			else
			{
				Console.Write(" Ei ole turkkia.");
			}
			return turkki;
		}
	}
}
