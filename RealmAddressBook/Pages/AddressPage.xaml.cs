﻿using RealmAddressBook.ViewModels;
using Xamarin.Forms;

namespace RealmAddressBook.Pages
{
	public partial class AddressPage : ContentPage
	{
		protected string PersonId;

		public AddressPage(string personId)
		{
			PersonId = personId;
			InitializeComponent();
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();
			if (BindingContext != null)
				(BindingContext as AddEditAddressViewModel).Init(PersonId);
		}
	}
}