using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Models;
using Xamarin.Forms;

namespace Cleaner.Pages
{
    public partial class MainPage : ContentPage
    {

        private Command moreShowsCommand;

        public MainPage()
        {
            InitializeComponent();

            MoreShowsCommand = new Command(MoreShows);

            BindingContext = this;
        }

        private void MoreShows(object obj)
        {
            App.Current.Navigation.PushAsync(new WebPage());
        }

        public Command MoreShowsCommand
        {
            get
            {
                return moreShowsCommand;
            }

            set
            {
                moreShowsCommand = value; OnPropertyChanged();
            }
        }

        public List<SampleCategory> Items
        {
            get
            {
                return SampleData.CategoryList;
            }
        }

        public List<Models.Cleaner> Favorites
        {
            get
            {
                return new List<Models.Cleaner>() {
                    SampleData.Cleaners[0],
                    SampleData.Cleaners[3],
                    SampleData.Cleaners[4],
                };
            }
        }
        

        //public async void OnItemTapped(object sender, EventArgs e)
        //{
        //    var selectedItem = ((ListView)sender).SelectedItem;
        //    var post = (Models.Cleaner)selectedItem;
        //    var articleView = new CleanerListPage();
        //    try
        //    {
        //        await App.Current.Navigation.PushAsync(articleView);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.ToString());
        //    }
        //}
    }
}
