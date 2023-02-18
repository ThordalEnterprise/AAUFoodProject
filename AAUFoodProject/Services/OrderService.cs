using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using AAUFoodProject.Model;
using AAUFoodProject.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AAUFoodProject.Services
{
    public class OrderService
    {
        FirebaseClient client;

        public string OrderId { get; set; }

        public decimal TotalCost { get; set; }

        public List<CartItem> Data { get; set; }

        public OrderService()
        {
            client = new FirebaseClient("https://aaudelevery.firebaseio.com/");

            OrderId = Guid.NewGuid().ToString();
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            Data = cn.Table<CartItem>().ToList();
            TotalCost = Data.Sum(d => d.Quantity * d.Price);
        }

    
        public async Task ProcessOrderAsync(string recieptId)
        {
            var uname = Preferences.Get("Username", "Guest");

            foreach (var item in Data)
            {
                OrderDetails od = new OrderDetails()
                {
                    OrderId = OrderId,
                    OrderDetailId = Guid.NewGuid().ToString(),
                    ProductID = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Quantity = item.Quantity
                };
                await client.Child("OrderDetails").PostAsync(od);
            }

            await client.Child("Orders").PostAsync(
                new Order()
                {
                    OrderId = OrderId,
                    Username = uname,
                    TotalCost = TotalCost,
                });
        }

        private void RemoveItemsFromCart()
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart();
        }


        public async Task<string> PlaceOrderAsync()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var data = cn.Table<CartItem>().ToList();

            var orderId = Guid.NewGuid().ToString();
            var uname = Preferences.Get("Username", "Guest");

            decimal totalCoast = 0;

            foreach (var item in data)
            {
                OrderDetails od = new OrderDetails()
                {
                    OrderId = orderId,
                    OrderDetailId = Guid.NewGuid().ToString(),
                    ProductID = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Quantity = item.Quantity
                };

                totalCoast += item.Price * item.Quantity;
                await client.Child("OrderDetails").PostAsync(od);
            }

            await client.Child("Orders").PostAsync(
            new Order()
            {
                OrderId = orderId,
                Username = uname,
                TotalCost = totalCoast
            });

            return orderId;
        }
    }
}
