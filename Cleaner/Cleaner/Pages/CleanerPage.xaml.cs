using System;
using Cleaner.Models;
using Cleaner.ViewModels;
using Xamarin.Forms;

namespace Cleaner.Pages
{
	public partial class CleanerPage : ContentPage
	{
		private TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();

        private Models.Cleaner _cleaner;

		public CleanerPage(Models.Cleaner cleaner)
		{
			InitializeComponent ();

            this.BindingContext = Cleaner = cleaner;
		}

        public Models.Cleaner Cleaner
        {
            get
            {
                return _cleaner;
            }

            set
            {
                _cleaner = value;
            }
        }

        protected override void OnAppearing ()
		{
			base.OnAppearing ();
			avatar.GestureRecognizers.Add(tapGestureRecognizer);
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			avatar.GestureRecognizers.Remove(tapGestureRecognizer);
		}

	}
}