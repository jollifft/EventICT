using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace EventICT
{
	public partial class EventsPage : ContentPage
	{
		EventsViewModel vm;
		public EventsPage ()
		{
			InitializeComponent ();
			BindingContext = vm = new EventsViewModel ();

		}

		protected override async void OnAppearing ()
		{
			base.OnAppearing ();

			await vm.GetEvents();
		}
	}
}

