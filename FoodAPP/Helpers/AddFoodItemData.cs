using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using FoodAPP.Model;
using Xamarin.Forms;

namespace FoodAPP.Helpers
{
    public class AddFoodItemData
    {
        FirebaseClient client;
        public List<FoodItem> FoodItem { get; set; }
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://foodapp-9afad-default-rtdb.firebaseio.com/");
            FoodItem = new List<FoodItem>()
            {
                new FoodItem
                {
                  ProductID = 1,
                  CategoryID = 1,
                  ImageUrl = "Burger",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 2,
                  CategoryID = 1,
                  ImageUrl = "Pizza",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },
                 new FoodItem
                {
                  ProductID = 3,
                  CategoryID = 1,
                  ImageUrl = "Rice",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Empty",
                 Price = 45
            },
                 new FoodItem
                {
                  ProductID = 4,
                  CategoryID = 1,
                  ImageUrl = "Burger",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Empty",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 5,
                  CategoryID = 2,
                  ImageUrl = "Pizzzzzza",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 1,
                  CategoryID = 2,
                  ImageUrl = "Pizzzzzza",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 6,
                  CategoryID = 2,
                  ImageUrl = "Pizzzzzza",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 7,
                  CategoryID = 2,
                  ImageUrl = "Pizzzzzza",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Empty",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 8,
                  CategoryID = 3,
                  ImageUrl = "Pancake",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Empty",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 9,
                  CategoryID = 3,
                  ImageUrl = "Pancake",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 10,
                  CategoryID = 3,
                  ImageUrl = "Pancake",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 11,
                  CategoryID = 3,
                  ImageUrl = "Pancake",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Empty",
                 Price = 45
            },

                 new FoodItem
                {
                  ProductID = 12,
                  CategoryID = 3,
                  ImageUrl = "Pancake",
                  Name = "Burger and Pizza Class",
                 Decription ="Burger and Pizza Breakfast",
                 Rating ="4.9",
                 RatingDetail = "(50 ratings)",
                 HomeSelected =  "Complete",
                 Price = 45
            },

    };

}
        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach (var item in FoodItem)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Decription = item.Decription,
                        HomeSelected = item.HomeSelected,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Price = item.Price,
                        Rating = item.Rating,
                        RatingDetail = item.RatingDetail

                    });
                }
            }

            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");

            }
        }


    }

}


