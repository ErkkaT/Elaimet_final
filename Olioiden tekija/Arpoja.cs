using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioiden_tekija
{
	class Arpoja 
	{
		private int ika;

		Random rnd = new Random();

		string[] nimet = new string[] { "Jaakko", "Aapo", "Juuso", "Arttu", "Aapeli", "Santeri", "Simo",
			   "Antti", "Risto", "Robert", "Timo", "Toni", "Tomi",
			   "Ismo", "Ilmari", "Olli", "Elias", "Heikki", "Johannes", "Jere",
			   "Justus", "Kalle", "Kimmo", "Lassi", "Lasse", "Leevi", "Valle",
			   "Viljami", "Benjamin", "Niko", "Niilo", "Mikko", "Markus", "Matias",

			   "Anni", "Anne", "Anna", "Esmeralda", "Enni", "Raili", "Rebecca", "Tanja",
			   "Tuuli", "Ilona", "Päivi", "Sanni", "Julia", "Kiira", "Kia",
			   "Karoliina", "Linda", "Valma", "Ninna", "Mirja", "Meiju"
			   };

		public int IkaArpa()
		{
			//arvotaan ikä
			int ika = rnd.Next(1,20);   
			return ika;
		}
		public string NimiArpa()
		{
			//arvotaan nimi yllä olevasta listasta
			int Index = rnd.Next(nimet.Length);
			return nimet[Index];
		}
	}
}
