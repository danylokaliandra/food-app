using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using FoodAPP.Model;


namespace FoodAPP.Views
{
    public partial class ProductsView : ContentPage
    {
        public ProductsView()
        {
            InitializeComponent();
        }

       async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var category = e.CurrentSelection.FirstOrDefault() as Category;
            if (category == null)
                return;

            await Navigation.PushModalAsync(new CategoryView(category));

            ((CollectionView) sender).SelectedItem = null;
        }
    }
}
