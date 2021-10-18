﻿using System;
using FoodAPP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new LogInView();
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