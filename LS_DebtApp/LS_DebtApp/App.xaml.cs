﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LS_DebtApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new Views.MainPage())
            {
                BarBackgroundColor = Color.Green,
                BarTextColor = Color.White
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
