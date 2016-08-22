using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cleaner.Pages
{
    public partial class WebPage : ContentPage
    {
        public WebPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            wvBrowser.Source = new UrlWebViewSource() { Url = "http://thevore.com/best-series/australian-tv-series/" };
        }
    }
}
