﻿using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;

namespace XamarinFormsSamples
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			MainPage = new NavigationPage(new StartPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
