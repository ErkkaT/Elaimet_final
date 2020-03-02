using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace kissanPennut
{
	class Program
	{
		static void Main(string[] args)
		{
			Kissa äiti1 = new Kissa(7, "Mallu");
			Kissa äiti2 = new Kissa(5, "Lallu");

			int maarA=äiti1.LisääPentu("miuku");
			Console.WriteLine(maarA);
			maarA = äiti1.LisääPentu("Mauku", 5);
			
			Console.WriteLine(maarA);
			maarA = äiti1.LisääPentu("Mellu");
			Console.WriteLine(maarA);

			Kissa pentu1 = new Kissa(6, "meuku", äiti1);
			Kissa pentu2 = new Kissa(5, "Minttu", äiti2);

			äiti2.LisääPentu2("Ville", 0, äiti2);
			äiti2.LisääPentu2("Pekka", 0, äiti2);
			äiti2.LisääPentu2("Musti", 0, äiti2);
			äiti2.LisääPentu2("Sakke", 0, äiti2);

			Console.WriteLine(pentu1.nimi + " " + pentu1.ika);

			Console.WriteLine(pentu2.nimi + " " + pentu2.ika);
			Console.WriteLine("printataan lista");


			Console.WriteLine(äiti1.nimi + "n pennut listattuna alas");
			äiti1.PalautaPennutLista();

			Console.WriteLine(äiti2.nimi + "n pennut listattuna alas");
			äiti2.PalautaPennutLista();
			Console.WriteLine("");
			Console.WriteLine("kuka on Pekan emo?");
			Console.WriteLine(pentu2.nimi + pentu2.Emo.nimi);



			Console.ReadKey();
		}
	}
}
