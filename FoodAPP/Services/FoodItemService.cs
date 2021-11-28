using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using FoodAPP.Model;
using System.Linq;
using Firebase.Database.Query;
using System.Collections.ObjectModel;

namespace FoodAPP.Services
{
    public class FoodItemService
    {
        FirebaseClient client;
        public FoodItemService()
        {
            client = new FirebaseClient("https://foodapp-9afad-default-rtdb.firebaseio.com/");
        }

        public async Task<List<FoodItem>> GetFoodItemAsync()
        {
            var products = (await client.Child("FoodItems")
                .OnceAsync<FoodItem>())
                .Select(f => new FoodItem
                {
                    CategoryID = f.Object.CategoryID,
                    Decription = f.Object.Decription,
                    HomeSelected = f.Object.HomeSelected,
                    ImageUrl = f.Object.ImageUrl,
                    Name = f.Object.Name,
                    Price = f.Object.Price,
                    ProductID = f.Object.ProductID,
                    Rating = f.Object.Rating,
                    RatingDetail = f.Object.RatingDetail

                }).ToList();
            return products;
        }

        public async Task<ObservableCollection<FoodItem>> GetFoodItemsByCategoryAsync(int categoryID)
        {
            var foodItemsByCayegory = new ObservableCollection<FoodItem>();
            var items = (await GetFoodItemAsync()).Where(p => p.CategoryID == categoryID).ToList();
            foreach (var item in items)
            {
                foodItemsByCayegory.Add(item);
            }

            return foodItemsByCayegory;
        }

        public async Task<ObservableCollection<FoodItem>> GetLatestFoodItemsAsync()
        {
            var lastestFoodItems = new ObservableCollection<FoodItem>();
            var items = (await GetFoodItemAsync()).OrderByDescending(f => f.Price).Take(3);
            foreach (var item in items)
            {
                lastestFoodItems.Add(item);
            }
            return lastestFoodItems;
        }
    }
}
