using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElainLuokat
{
	 public abstract class Elain
	{
		public int ika;
		public string nimi;
		public bool lihanSyoja;

		public Elain()
		{
			ika = 1;
			nimi = "Otus";
		}


		public Elain(int age, string name)
		{
			ika = age;
			nimi = name;
		}

		public Elain(Random noppa)
		{
			List<string> nimia = new List<string> { "miuku", "mauku", "hauku", "lauku", "Pekka" };

			ika = 3;
			int moneskoNimi = noppa.Next(0, nimia.Count);
			nimi = nimia[moneskoNimi];
		}

		public bool AsetaElaimenIka(int age)
		{
			//Tarkistaa onko ikä positiivinen
			if (ika < 0)
			{
				return false;
			}
			else
			{
				ika = age;
				return true;
			}
		}

		//Asettaa nimen
		public void AsetaElaimenNimi(string haluttuNimi)
		{
			nimi = haluttuNimi;
		}

		public int PalautaElaimenIka()
		{
			return ika;
		}


		public string PalautaElaimenNimi()

		{
			return nimi;
		}

		public void AsetaOnLihanSyoja(bool lihansyöjä)
			{
			lihanSyoja = lihansyöjä;
		}

		public bool PalautaOnLihanSyoja()
		{

			if (lihanSyoja == true)
			{
				Console.Write("Olen lihansyöjä.");
			}
			else
			{
				Console.Write("En ole lihansyöjä.");
			}
			return lihanSyoja;
		}

		public virtual void ääntele()
		{
			Console.WriteLine("Umph!");

		}


	}
}
