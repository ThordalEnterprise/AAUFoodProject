using System;
using System.Collections.Generic;
using System.Linq;
using AAUFoodProject.Model;
using AAUFoodProject.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class SearchResultsView : ContentPage
    {
        SearchResultsViewModel srvm;
        public SearchResultsView(string searchText)
        {
            InitializeComponent();
            srvm = new SearchResultsViewModel(searchText);
            this.BindingContext = srvm;
            LabelName.Text = $"Welcome {Preferences.Get("Username", "Guest")}";
        }

        async void back_button(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Chosen_item(System.Object sender,
            Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as FoodItem;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductDetailsView(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;
        }
    }

}
