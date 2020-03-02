using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
			//Tässä luot luokasta olion.
			Hevonen heppa = new Hevonen(35, "Heikki");

			
			//Kissa cat2 = new Kissa(12, "Mauku");
			Elain teht4 = new Hevonen(5, "Anneli");
			Koira dog1 = new Koira();
			Elain elukka2 = new Koira();
			Elain elukka1 = new Koira();
			Linnut Pele = new Linnut();


			/*
			Console.WriteLine("-------------------");
			Console.WriteLine("---Heppa tehtävä---");
			Console.WriteLine("-------------------");
			
			//Tulosta olion nimi ja paino
			Console.WriteLine("vanha nimi " + heppa.Nimi + " ja paino " + heppa.Paino);

			//Muuta olion nimeä ja painoa
			heppa.Nimi = "Jaakko";
			heppa.Paino = 73;

			//Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
			Console.WriteLine("uusi nimi: " + heppa.Nimi + " ja paino: " + heppa.Paino);
			
			Console.WriteLine("-------------------");
			Console.WriteLine("---Kissa tehtävä---");
			Console.WriteLine("-------------------");

			Console.WriteLine(cat1.PalautaKissanNimi());
			cat1. ("HildA");
			Console.WriteLine(cat1.PalautaKissanNimi());

			Console.WriteLine("Nimi "+ cat1.nimi +" ja ikä " + cat1.PalautaKissanIka());

			cat1.AsetaKissanIka(7);
			Console.WriteLine("Asetetaan uusi ikä");
			Console.WriteLine(cat1.PalautaKissanIka());

			Console.WriteLine("-------------------");
			Console.WriteLine("---Koira tehtävä---");
			Console.WriteLine("-------------------");

			Console.WriteLine("Koiran nimi on " + dog1.nimi);

			dog1.AsetaKoiranNimi("Max");
			Console.WriteLine(dog1.PalautaKoiranNimi());

			dog1.AsetaKoiranNimi("musti");
			Console.WriteLine(dog1.PalautanNimi());

			Console.WriteLine();
			*/
			Console.WriteLine("Define Array Size? ");
			int number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter numbers:\n");
			int[] arr = new int[number];

			for (int i = 0; i < number; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("Array Index: " + i + " AND Array Item: " + arr[i].ToString());
			}


			Console.WriteLine(elukka1.PalautaElaimenIka());
			Console.WriteLine(elukka1.PalautaElaimenNimi());
			elukka1.PalautaOnLihanSyoja();
			Console.WriteLine("");

			Console.WriteLine(elukka2.PalautaElaimenIka());
			Console.WriteLine(elukka2.PalautaElaimenNimi());
			elukka2.PalautaOnLihanSyoja();


			

			Console.ReadKey();
			
		}
    }
}
