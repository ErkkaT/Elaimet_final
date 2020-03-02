using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
	public class Kissa
	{
		private int ika;
		private string nimi;


		public Kissa()
		{
		  ika = 0;
		  nimi = "Makke";
		}

		public Kissa(int age, string name)
		{
			ika = age;
			nimi = name;
		}
		


	}
}
