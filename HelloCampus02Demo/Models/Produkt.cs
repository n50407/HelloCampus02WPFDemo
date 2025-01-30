using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.Models
{
    internal class Produkt
    {
		private int _ProduktID;

		public int ProduktID
		{
			get { return _ProduktID; }
			set { _ProduktID = value; }
		}
		private string _Bezeichnung;

		public string Bezeichnung
		{
			get { return _Bezeichnung; }
			set { _Bezeichnung = value; }
		}

		private string _Kategorie;

		public string Kategorie
		{
			get { return _Kategorie; }
			set { _Kategorie = value; }
		}
		private bool _AufLager;

		public bool AufLager
		{
			get { return _AufLager; }
			set { _AufLager = value; }
		}
		private double _Preis;

		public double Preis
		{
			get { return _Preis; }
			set { _Preis = value; }
		}


	}
}
