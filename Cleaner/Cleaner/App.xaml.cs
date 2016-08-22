using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cleaner.Helpers;
using Xamarin.Forms;

namespace Cleaner
{
    public partial class App : Application
    {

        public NavigationService Navigation { get; set; }

        public static new App Current { get; private set; }

        public App()
        {
            InitializeComponent();

            Current = this;
            MainPage = new Cleaner.Pages.RootPage(true);
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
