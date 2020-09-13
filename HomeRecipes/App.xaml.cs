using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeRecipes.Views;

namespace HomeRecipes
{
    public partial class App : Application
    {
        public static string FilePath;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeView());
        }
        public App(string FilePath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
