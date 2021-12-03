using System;
namespace FoodAPP.Model
{
    public class Order
    {
        public string OrderId { get; set; }
        public string Username { get; set; }
        public decimal TotalCost { get; set; }
    }
}
