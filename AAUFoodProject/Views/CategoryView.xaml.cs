using System;
using System.Collections.Generic;
using System.Linq;
using AAUFoodProject.Model;
using AAUFoodProject.ViewModels;
using Xamarin.Forms;

namespace AAUFoodProject.Views
{
    public partial class CategoryView : ContentPage
    {
        CategoryViewModel cvm;
        public CategoryView(Category category)
        {
            InitializeComponent();
            cvm = new CategoryViewModel(category);
            this.BindingContext = cvm;
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
