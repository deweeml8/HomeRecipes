using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HomeRecipes.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            BindingContext = new HomeRecipes.ViewModels.HomeViewModel();
        }
    }
}
