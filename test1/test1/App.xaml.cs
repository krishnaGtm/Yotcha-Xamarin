using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace test1
{
	public partial class App : Application
	{
        public static NavigationPage Navigation;
		public App ()
		{
			InitializeComponent();

            //MainPage = new test1.MainPage();
            MainPage = new test1.View.SignIn();
            //MainPage = Navigation = new NavigationPage(new View.SignIn());
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
