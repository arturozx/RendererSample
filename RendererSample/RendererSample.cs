using System;

using Xamarin.Forms;

namespace RendererSample
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			NavigationPage root = new NavigationPage(new MyPage());
			MainPage = root;
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

