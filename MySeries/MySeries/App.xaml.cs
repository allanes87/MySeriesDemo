using MySeries.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MySeries
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        private void SetMainPage()
        {
            Page mainPage = new MySeriesPage();

            NavigationPage navigationPage = new NavigationPage(mainPage);
            navigationPage.BarBackgroundColor = Color.Black;
            navigationPage.BarTextColor = Color.White;

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
