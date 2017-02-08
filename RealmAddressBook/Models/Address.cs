using System;
using Realms;

namespace RealmAddressBook
{
	public class Address : RealmObject
	{
		//[ObjectId]
		public string ID { get; set; }

		public string Indirizzo
		{
			set;
			get;
		}

		public int NumeroCivico
		{
			set;
			get;
		}

		public string CAP
		{
			set;
			get;
		}

		public string Localita
		{
			set;
			get;
		}

		public string Provincia
		{
			set;
			get;
		}

		public string Nazione
		{
			set;
			get;
		}

		public Address()
		{
		}
	}
}
