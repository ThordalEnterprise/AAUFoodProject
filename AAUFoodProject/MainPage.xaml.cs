using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AAUFoodProject.Services;
using Xamarin.Forms;

namespace AAUFoodProject
{
    public partial class MainPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public MainPage()
        {

            InitializeComponent();
        }

      
    }
}
