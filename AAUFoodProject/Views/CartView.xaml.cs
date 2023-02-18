using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class CartView : ContentPage
    {
        public CartView()
        {
            InitializeComponent();
            LabelName.Text = "Welcome " + Preferences.Get("Username", "Guest");
        }

        async void back_button(System.Object sender, System.EventArgs e)
        {
            await Application.Current.MainPage.Navigation.
                PushModalAsync(new ProductsView());
        }
    }

}
