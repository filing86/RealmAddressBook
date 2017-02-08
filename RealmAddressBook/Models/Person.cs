using Realms;
namespace RealmAddressBook
{
	public class Person : RealmObject
	{
		//[ObjectId]
		public string ID { get; set; }

		public string Nome
		{
			get;
			set;
		}

		public string Cognome
		{
			get;
			set;
		}



		public string NomeCompleto
		{
			get
			{
				return string.Format("{0} {1}", Nome, Cognome);
			}
		}

		//public RealmList<Address> Addresses
		//{
		//	get;

		//}

		public Person()
		{
		}
	}
}
