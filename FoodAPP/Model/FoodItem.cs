using System;
namespace FoodAPP.Model
{
    public class FoodItem
    {
       public int ProductID { get; set; }
       public string ImageUrl { get; set; }
       public string Name { get; set; }
       public string Decription { get; set; }
       public string Rating { get; set; }
       public string RatingDetail { get; set; }
       public string HomeSelected { get; set; }
       public object MyProperty { get; set; }
       public int CategoryID { get; set; }
       public int Price { get; set; }
    }
}
