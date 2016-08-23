using System;
using Cleaner.Models;
using Cleaner.ViewModels;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Cleaner.Pages
{
	public partial class CleanerListPage : ContentPage
	{
	

		public CleanerListPage()
		{
			InitializeComponent ();
            BindingContext = this; 
		}

        public List<Models.Cleaner> Cleaners {
            get
            {
                return SampleData.Cleaners;
            }
        }


        protected override void OnAppearing (){
			base.OnAppearing ();
            
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			
		}


		public void OnMore (object sender, EventArgs e) {
			var mi = ((MenuItem)sender);
			DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
		}

		public void OnDelete (object sender, EventArgs e) {
			var mi = ((MenuItem)sender);
			DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
		}

		public void OnItemTapped (object sender, EventArgs e) {
            var item = (Models.Cleaner)((ListView)sender).SelectedItem;

            App.Current.Navigation.PushAsync(new CleanerPage(item));
        }

		public void OnPrimaryActionButtonClicked (object sender, EventArgs e){

		}
	}
}

