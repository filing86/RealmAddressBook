using System;
using System.Collections.Generic;
using Realms;

namespace RealmAddressBook.Models
{
	public class Person : RealmObject
	{

		//[ObjectId]
		internal List<Address> ToList()
		{
			throw new NotImplementedException();
		}

		internal void Add(Address newAddress)
		{
			throw new NotImplementedException();
		}

		public string ID { get; set; }

		public static void Add(Person instance, Address newAddress)
		{
			throw new NotImplementedException();
		}

		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}



		public string FullName
		{
			get
			{
				return string.Format("{0} {1}", FirstName, LastName);
			}
		}

		public RealmList<Address> Addresses
		{
			get;

		}

		public Person()
		{
		}
	}

	public class RealmList<T>
	{
}
}