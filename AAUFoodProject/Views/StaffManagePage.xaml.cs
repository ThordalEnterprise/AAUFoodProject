using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class StaffManagePage : ContentPage
    {
        public StaffManagePage()
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
