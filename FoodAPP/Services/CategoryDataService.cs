﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using FoodAPP.Model;
using System.Linq;
using Firebase.Database.Query;

namespace FoodAPP.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;
        public CategoryDataService()
        {
            client = new FirebaseClient("https://foodapp-9afad-default-rtdb.firebaseio.com/");

        }

        public async Task<List<Category>> GetCategoryAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName,
                    CategoryPoster = c.Object.CategoryPoster,
                    ImageUrl = c.Object.ImageUrl

                }).ToList();
            return categories;
        }
    }
}
