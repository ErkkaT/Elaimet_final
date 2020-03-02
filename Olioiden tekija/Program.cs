


using ElainLuokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioiden_tekija
{
	class Program : Arpoja
	{
		static void Main()
		{

			Arpoja arpa = new Arpoja();

			//looppi jossa kissa koira hevonen 
			//joka 4. on hevonen joka korvaa paikaalla olleen kissan, koiran tai papukaijan
			//c = cat
			//d = dog 
			//p = parrot
			//h = horse
			/*
			 OUTPUT:
				kissa
				koira
				papukaija
				hevonen //korvaa kissan
				koira
				papukaija
				kissa
				hevonen //korvaa koiran
				papukaija
				kissa
				koira
				hevonen //korvaa papukaijan
			*/
			// jatkuu x monta kertaa
			// jossa x = käyttäjän antama arvo

			/*

		   */

			//tee lista, jotta voit luoda oliot loopissa.
			
			
			Console.Write("Kuinka pitkä lista tehdään? ");
			int x = Int32.Parse(Console.ReadLine());

			int j = 0;
			List <Elain> elainlista = new List<Elain>();

			for (int i = 1; i < x; i++)
			{
			
				if ((i % 4) == 0)
				{
					int arvottuika = arpa.IkaArpa();
					string arvottunimi = arpa.NimiArpa();
					Hevonen horse = new Hevonen(arvottuika, arvottunimi);
					elainlista.Add(horse);
					horse.AsetaOnLihanSyoja(false);
					horse.AsetaOnkoTurkki(false);

					Console.Write(" Olen hevonen nimeltä " + horse.Nimi + " ja ikäni on " + horse.ika + ". ");
					horse.PalautaOnLihanSyoja();
					horse.PalautaOnkoTurkki();
					Console.WriteLine("");
					i++; // i++ avulla hevonen tulee aina joka 4. kerta
				}
				
				if ((i % 3) == 1)
				{

					int arvottuika = arpa.IkaArpa();
					string arvottunimi = arpa.NimiArpa();
					Kissa cat = new Kissa(arvottuika, arvottunimi);

					cat.AsetaOnLihanSyoja(true);
					elainlista.Add(cat);
					cat.AsetaOnLihanSyoja(true);
					cat.AsetaOnkoTurkki(true);

					Console.Write(" Olen kissa nimeltä " + cat.nimi + " ja ikäni on " + cat.ika + ". ");
					cat.PalautaOnLihanSyoja();
					cat.PalautaOnkoTurkki();
					Console.WriteLine("");
				}
				if ((i % 3) == 2)
				{
					
					int arvottuika = arpa.IkaArpa();
					string arvottunimi = arpa.NimiArpa();
					Koira dog = new Koira(arvottuika, arvottunimi);
					dog.AsetaOnLihanSyoja(true);
					dog.AsetaOnkoTurkki(true);
					elainlista.Add(dog);//lisää oikea olio eikä mitää elainta

					Console.Write(" Olen koira nimeltä " + dog.nimi + " ja ikäni on " + dog.ika + ". ");
					dog.PalautaOnLihanSyoja();
					dog.PalautaOnkoTurkki();
					Console.WriteLine("");
				}

				if ((i % 3) == 0)
				{
					int arvottuika = arpa.IkaArpa();
					string arvottunimi = arpa.NimiArpa();
					Linnut parrot = new Linnut(arvottuika, arvottunimi);
					elainlista.Add(parrot);
					parrot.AsetaOnLihanSyoja(true);					
					parrot.AsetaOnkoPaikannin(true);

					Console.Write(" Olen papukaija nimeltä " + parrot.nimi + " ja ikäni on " + parrot.ika + ". ");
					parrot.PalautaOnLihanSyoja();
					parrot.PalautaOnkoPaikannin();
					Console.WriteLine("");
				}

			}

			/*
			foreach (Elain elukka in elainlista)
				//elukka kai dog vai parrot?
			{
				Console.WriteLine(" " + elukka.nimi + "  " + elukka.ika + " " + elukka.PalautaOnLihanSyoja());
				
			}
			
			*/

			Console.WriteLine("nyt pitäis tulla uus lista");
		
			elainlista.ForEach(Console.WriteLine);

			Console.WriteLine("");
			Console.WriteLine("Hevoset:");
			foreach (Elain elukka in elainlista.OfType<Hevonen>())
			{
				Console.Write(elukka.nimi + " " + elukka.PalautaElaimenIka() + " ");
				elukka.PalautaOnLihanSyoja();
				Console.WriteLine("");
			}
			Console.WriteLine("");
			Console.WriteLine("Kissat:");
			foreach (Elain elukka in elainlista.OfType<Kissa>())
			{
				Console.Write(elukka.nimi + " " + elukka.PalautaElaimenIka() + " ");
				elukka.PalautaOnLihanSyoja();
				Console.WriteLine("");
			}
			Console.WriteLine("");
			Console.WriteLine("Koirat:");
			foreach (Elain elukka in elainlista.OfType<Koira>())
			{
				Console.Write(elukka.nimi + " " + elukka.PalautaElaimenIka() + " ");
				elukka.PalautaOnLihanSyoja();
				Console.WriteLine("");
			}
			Console.WriteLine("");
			Console.WriteLine("Papukaijat:");
			foreach (Elain elukka in elainlista.OfType<Linnut>())
			{
				Console.Write(elukka.nimi + " " + elukka.PalautaElaimenIka() + " ");
				elukka.PalautaOnLihanSyoja();
				Console.WriteLine("");
			}


			Console.ReadKey();
		}
	}
}
