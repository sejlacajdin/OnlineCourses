﻿using OnlineCourseApp.Mobile.Services;
using OnlineCourseApp.Mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
