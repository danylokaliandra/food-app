﻿using System;
using System.Collections.Generic;
using FoodAPP.Helpers;

using Xamarin.Forms;

namespace FoodAPP.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

       async void ButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }

        async void ButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddFoodItemData();
            await afd.AddFoodItemAsync();
        }
    }
}
