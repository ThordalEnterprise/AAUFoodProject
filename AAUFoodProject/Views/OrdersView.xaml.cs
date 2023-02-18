using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class OrdersView : ContentPage
    {
        public OrdersView(string id)
        {
            InitializeComponent();
            LabelName.Text = "Thank you " +
                Preferences.Get("Username", "Guest") + " for using AAU Food ";
            LabelOrderID.Text = id;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductsView());
        }
    }


}
