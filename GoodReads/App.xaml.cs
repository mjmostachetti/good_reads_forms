﻿using Xamarin.Forms;
using SQLite;

namespace GoodReads
{
	public partial class App : Application
	{
		static GoodReadsDatabase database;

		public App()
		{
			InitializeComponent();



			MainPage = new GoodReadsPage();
		}

		public static GoodReadsDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new TodoItemDatabase();
				}
				return database;
			}
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

