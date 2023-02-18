
using System;
using System.Collections.Generic;
using AAUFoodProject.Model;
using AAUFoodProject.ViewModels;
using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class ProductDetailsView : ContentPage
    {
        ProductDetailsViewModel pvm;
        public ProductDetailsView(FoodItem foodItem)
        {
            InitializeComponent();
            pvm = new ProductDetailsViewModel(foodItem);
            this.BindingContext = pvm;
        }

        async void back_button(System.Object sender,
            System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }



}

