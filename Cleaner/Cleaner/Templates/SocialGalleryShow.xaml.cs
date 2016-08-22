using System;
using System.Collections.Generic;
using Cleaner.Models;
using Cleaner.Pages;
using Cleaner.ViewModels;
using Xamarin.Forms;

namespace Cleaner.Templates
{
	public partial class SocialGalleryShow : ContentView
	{
	
        public static BindableProperty ShowProperty =
    BindableProperty.Create("Show", typeof(Models.Cleaner),
        typeof(SocialGalleryShow),
        null,
        defaultBindingMode: BindingMode.OneWay
    );

        public Models.Cleaner Cleaner
        {
            get { return (Models.Cleaner)GetValue(ShowProperty); }
            set { SetValue(ShowProperty, value); }
        }

        public SocialGalleryShow()
		{			
			InitializeComponent ();
		}

		private async void OnImageTapped(Object sender, EventArgs e){
            var selectedItem = (SocialGalleryShow)sender;

            await Navigation.PushAsync(new ShowViewPage(new ShowViewModel(selectedItem.Show)));
        }
	}
}