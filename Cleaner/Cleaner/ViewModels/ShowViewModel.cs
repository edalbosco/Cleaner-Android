using System;
using System.Collections.Generic;
using System.Linq;
using Cleaner.Helpers;
using Cleaner.Models;
using Xamarin.Forms;

namespace Cleaner.ViewModels
{
	public class ShowViewModel
	{
		public ShowViewModel() : this(new Models.Cleaner(null, "","",false)) {
		}

		public ShowViewModel(Models.Cleaner post){
			this.TVShow = post;
        }

		public Models.Cleaner TVShow { get; private set;}

	}
}