using System;
using System.Collections.Generic;

using Xamarin.Forms;
using RealmAddressBook.ViewModels;

namespace RealmAddressBook.Pages
{
	public partial class PersonPage : ContentPage
	{
		protected string PersonId;


		public PersonPage(string id)
		{
			PersonId = id;
			InitButtons();
		}


		public PersonPage()
		{
			InitButtons();
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();
			if (this.BindingContext != null)
				(BindingContext as AddEditPersonViewModel).Init(PersonId);
		}


		void InitButtons()
		{
			ToolbarItems.Add(new ToolbarItem("Delete", null, () => (BindingContext as AddEditPersonViewModel).DeleteCommand.Execute(null)));

			AddAddressButton.Clicked += (sender, e) => this.Navigation.PushAsync(new AddressPage(PersonId));
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (BindingContext != null)
				(BindingContext as AddEditPersonViewModel).Refresh();
		}
	}
}