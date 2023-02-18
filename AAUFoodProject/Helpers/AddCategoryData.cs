using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using AAUFoodProject.Model;
using Xamarin.Forms;

namespace AAUFoodProject.Helpers
{
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://aaudelevery.firebaseio.com/");
            Categories = new List<Category>()
            {
                new Category(){
                    CategoryID = 1,
                    CategoryName = "Burger",
                    CategoryPoster = "MainBurger.jpg",
                    ImageUrl = "Burger.png"
                },
                new Category(){
                    CategoryID = 2,
                    CategoryName = "Pizza",
                    CategoryPoster = "MainPizza.jpg",
                    ImageUrl = "Pizza.png"
                },
                new Category(){
                    CategoryID = 3,
                    CategoryName = "Desserts",
                    CategoryPoster = "MainDessert.jpg",
                    ImageUrl = "Dessert.png"
                },
                new Category(){
                    CategoryID = 4,
                    CategoryName = "Vegetarian",
                    CategoryPoster = "MainVeggi.jpg",
                    ImageUrl = "Veggie.png"
                },
                  new Category(){
                    CategoryID = 5,
                    CategoryName = "Drinks",
                    CategoryPoster = "Drinkscover.jpg",
                    ImageUrl = "Drinksicon.png"
                },

            };
        }
        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        CategoryPoster = category.CategoryPoster,
                        ImageUrl = category.ImageUrl
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

    public class AddadminUser
    {
        public List<AdminUserModel> AdminUsers { get; set; }
        FirebaseClient client;
        public AddadminUser()
        {
            client = new FirebaseClient("https://aaudelevery.firebaseio.com/");
            AdminUsers = new List<AdminUserModel>()
            {
                new AdminUserModel(){
                    AdminUsername = "Admin123",
                    AdminPassword = "Admin123"
                }
                
            };
        }
        public async Task AddadminUserAsync()
        {
            try
            {
                foreach (var adminUsers in AdminUsers)
                {
                    await client.Child("AdminUsers").PostAsync(new AdminUserModel()
                    {
                        AdminUsername = adminUsers.AdminUsername,
                        AdminPassword = adminUsers.AdminPassword

                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }


    }

    public class AddstaffUser
    {
        public List<StaffUserModel> StaffUsers { get; set; }
        FirebaseClient client;
        public AddstaffUser()
        {
            client = new FirebaseClient("https://aaudelevery.firebaseio.com/");
            StaffUsers = new List<StaffUserModel>()
            {
                new StaffUserModel(){
                    StaffPassword = "Staff123",
                    StaffUsername = "Staff123"
                }

            };
        }
        public async Task AddstaffUserAsync()
        {
            try
            {
                foreach (var staffUsers in StaffUsers)
                {
                    await client.Child("StaffUsers").PostAsync(new StaffUserModel()
                    {
                        StaffUsername = staffUsers.StaffUsername,
                        StaffPassword = staffUsers.StaffPassword

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
    
