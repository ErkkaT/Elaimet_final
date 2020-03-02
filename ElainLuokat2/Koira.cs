using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
	public class Koira : Nisakkaat
	{
		public Koira()
		{
			ika = 0;
			nimi = "Koiruli";
		}

		public Koira(int age, string name)
		{
			ika = age;
			nimi = name;
		}

	

		public override void ääntele()
		{

			//Muiunnetaan Umph! koiranomaksi ääneksi
			{
				Console.WriteLine("Hau!");
			}
		}


	}
}
