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

        ObservableCollection<ImageSource> _images;
        int idx;

        public MainPage()
        {
            InitializeComponent();

            MoreShowsCommand = new Command(MoreShows);

            idx = 2;

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
                    SampleData.Cleaner[0],
                    SampleData.Cleaner[3],
                    SampleData.Cleaner[4],
                };
            }
        }
        

        public async void OnItemTapped(object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var post = (Models.Cleaner)selectedItem;
            var articleView = new ShowViewPage(new ViewModels.ShowViewModel(post));
            try
            {
                await App.Current.Navigation.PushAsync(articleView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
