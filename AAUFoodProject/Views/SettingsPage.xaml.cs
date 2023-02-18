using System;
using System.Collections.Generic;
using AAUFoodProject.Helpers;
using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        async void ButtonAdmin_user_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddadminUser();
            await afd.AddadminUserAsync();
        }
        async void RDButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductsView());

        }
        async void ButtonStaff_user_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddstaffUser();
            await afd.AddstaffUserAsync();
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
        void ButtonCart_Clicked(System.Object sender, System.EventArgs e)
           {
          var cct = new CreateCartTable();
            if (cct.CreateTable())
           DisplayAlert("Success", "Cart Table Created", "Ok");
             else
           DisplayAlert("Error", "Error while creating table", "Ok");
          }
        async void UpdateButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddCategoryData();
            await afd.AddCategoriesAsync();
        }
        async void UpadteButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddFoodItemData();
            await afd.AddFoodItemAsync();
        }
        async void UpdateButtonStaff_user_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddstaffUser();
            await afd.AddstaffUserAsync();
        }
        async void updateButtonAdmin_user_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddadminUser();
            await afd.AddadminUserAsync();
        }

        async void DeleteButtonStaff_user_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddadminUser();
            await afd.AddadminUserAsync();
        }

        async void DeleteButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddadminUser();
            await afd.AddadminUserAsync();
        }

        async void DeleteButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddadminUser();
            await afd.AddadminUserAsync();
        }

        async void DeleteButtonAdmin_user_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddadminUser();
            await afd.AddadminUserAsync();
        }









    }
}
