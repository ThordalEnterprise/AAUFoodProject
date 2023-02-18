using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class LogoutView : ContentPage
    {
        public LogoutView()
        {
            InitializeComponent();
        }

        async void back_button(System.Object sender,
            System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }


}
