using System;
using System.Collections.Generic;
using System.Linq;
using Cleaner.Models;

namespace Cleaner.ViewModels
{
	public class HomeViewModel
	{
		public HomeViewModel() {
		}
			
		public List<User> Friends 
		{ 
			get
			{
				return SampleData.Users;
			}
		}


	}
}