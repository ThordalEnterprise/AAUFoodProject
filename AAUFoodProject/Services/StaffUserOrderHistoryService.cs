using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using AAUFoodProject.Model;
using Xamarin.Essentials;
using Firebase.Database.Query;

namespace AAUFoodProject.Services
{


    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://aaudelevery.firebaseio.com/");

        public async Task<List<OrdersHistory>> GetHistory()
        {

            return (await firebase
              .Child("Orders")
              .OnceAsync<OrdersHistory>()).Select(item => new OrdersHistory
              {
                  OrderId = item.Object.OrderId,
                  Username = item.Object.Username,
                  TotalCost = item.Object.TotalCost,
              }).ToList();
        }

        public async Task AddHistory(string myKey, string myKey2, decimal myKey3)
        {

            await firebase
              .Child("Vehicle")
              .PostAsync(new OrdersHistory() { OrderId = myKey, Username = myKey2, TotalCost = myKey3 });
        }
    }






    public class StaffUserOrderHistoryService
    {
        FirebaseClient client;
        //kig ned
        readonly List<OrdersHistory> UserOrders;

        public StaffUserOrderHistoryService()
        {
            client = new FirebaseClient("https://aaudelevery.firebaseio.com/");
            UserOrders = new List<OrdersHistory>();
        }

        public async Task<List<OrdersHistory>> GetAlOrderDetailsAsync()
        {

            var orders = (await client.Child("Orders")
                .OnceAsync<Order>())
                .Select(o => new Order
                {
                    OrderId = o.Object.OrderId,
                    TotalCost = o.Object.TotalCost,
                }).ToList();

            foreach (var order in orders)
            {
                OrdersHistory uoh = new OrdersHistory();
                uoh.OrderId = order.OrderId;
                uoh.TotalCost = order.TotalCost;

                var orderDetails = (await client.Child("OrderDetails")
                .OnceAsync<OrderDetails>())
                .Select(o => new OrderDetails
                {
                    OrderId = o.Object.OrderId,
                    OrderDetailId = o.Object.OrderDetailId,
                    ProductID = o.Object.ProductID,
                    ProductName = o.Object.ProductName,
                    Quantity = o.Object.Quantity,
                    Price = o.Object.Price
                }).ToList();

                UserOrders.Add(uoh);
            }

            return UserOrders;
        }

    }

}
