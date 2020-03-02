using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
	public class Kissa : Nisakkaat
	{

		private Kissa emo;

		//Lisää kissa luokalle uusi lista Kissa olioista
		public List<Kissa> pennut = new List<Kissa>();

		public Kissa Emo { get => emo; set => emo = value; }


		
		
		public Kissa()
		{
			ika = 0;
			nimi = "Kisu";
		}
		public Kissa(int age, string name)
		{
			ika = age;
			nimi = name;
		}
		public Kissa(int age, string name, Kissa mother)
		{
			Emo = mother;
			ika = age;
			nimi = name;
		}
		public void Kehrää()
		{
			Console.WriteLine("Purrrr");
		}
		public override void ääntele()
		{
			//base.ääntele();
			{
				Console.WriteLine("Miau!");
			}
		
		}

		public int LisääPentu(string name, int age = 0)
		{
			//tarkoittaako this tässä kohtaa Kissa oliota?
			Kissa pentu = new Kissa(age, name, this);
			pennut.Add(pentu);
			return pennut.Count;

		}
		public void LisääPentu2(string nimi, int ikä, Kissa emo)
		{

			Kissa pentu1 = new Kissa(0, nimi, emo);
			pennut.Add(pentu1);
		}

		//printtaa listan, jossa näkyy tietyn äidin pennut
		public void PalautaPennutLista()
		{
			//tulostaa Elainluokat.Kissa
			//pennut.ForEach(Console.WriteLine);

			//tulostaa nimen ja iän
			foreach (Kissa pentu in pennut)
			{
				Console.WriteLine(pentu.nimi + " " + pentu.ika + " ja pennun emon nimi:" + pentu.Emo.PalautaElaimenNimi());
			}

		}
	}
}
