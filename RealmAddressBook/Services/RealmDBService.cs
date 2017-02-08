using System;
using System.Collections.Generic;
using Realms;

namespace RealmAddressBook
{
	public class RealmDBService
	{
		protected Realm RealmInstances;
		public RealmDBService()
		{

			this.RealmInstances = Realm.GetInstance();
		}

		#region IDBService implementation

		public bool SavePerson(string nome, string cognome)
		{

			try
			{
				RealmInstances.Write(() =>
				{
					var person = RealmInstances.CreateObject<Person>();
					person.Nome = nome;
					person.Cognome = cognome;
				});

				return true;
			}
			catch
			{
				return false;
			}
		}

		//public List<Person> GetPeople()
		//{

		//}

		#endregion
	}
}
