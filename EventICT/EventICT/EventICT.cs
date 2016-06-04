using System;

using Xamarin.Forms;

namespace EventICT
{
	public class App : Application
	{
		public static DataStore Store { get; private set; }
		public App ()
		{
			Store = new DataStore ();
			// The root page of your application
			MainPage = new NavigationPage(new EventsPage()){
				BarBackgroundColor = Color.Red
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

