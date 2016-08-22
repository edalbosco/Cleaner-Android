using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Cleaner.Models
{
	public static class SampleData
	{
		public static string[] Names = {
            "Pat Davies",
            "Janis Spector",
            "Regina Joplin",
            "Jaco Morrison",
            "Margaret Whites",
            "Skyler Harrisson"
        };
        
		public static List<string> UsersImagesList = new List<string>() { 
			"friend_thumbnail_27.jpg",
			"friend_thumbnail_31.jpg",
			"friend_thumbnail_34.jpg",
            "friend_thumbnail_55.jpg",
			"friend_thumbnail_71.jpg",
			"friend_thumbnail_75.jpg",
		};

		public static List<string> DashboardImagesList = new List<string>() {
            "dishes.jpg",
            "external.jpg",
            "hazardous.jpg",
            "hotel.jpg",
            "household.jpg",
            "Ice.jpg",
            "janitor.jpg",
            "laundry.jpg",
            "sewer.jpg",
		};

        public static string[] CategoriesColors = {
            "#c01e5c",
            "#ab1958",
            "#861350",
            "#473957",
            "#554666",
            "#5a5586",
            "#4d75a5",
            "#509acb",
            "#5abaeb"
        };

        public static List<SampleCategory> CategoryList = new List<SampleCategory>()
        {
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[0]),
                BackgroundImage=DashboardImagesList[0],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[1]),
                BackgroundImage=DashboardImagesList[1],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[2]),
                BackgroundImage=DashboardImagesList[2],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[3]),
                BackgroundImage=DashboardImagesList[3],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[4]),
                BackgroundImage=DashboardImagesList[4],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[5]),
                BackgroundImage=DashboardImagesList[5],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[6]),
                BackgroundImage=DashboardImagesList[6],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[7]),
                BackgroundImage=DashboardImagesList[7],
                Icon='\uf0e6'
            },
            new SampleCategory()
            {
                Name="",
                BackgroundColor=Color.FromHex(CategoriesColors[8]),
                BackgroundImage=DashboardImagesList[8],
                Icon='\uf0e6'
            },
        };


		public static List<User> Users = new List<User> {
			new User( Names[0], UsersImagesList[0] ),
			new User( Names[1], UsersImagesList[1] ),
			new User( Names[2], UsersImagesList[2] ),
			new User( Names[3], UsersImagesList[3] ),
			new User( Names[4], UsersImagesList[4] ),
			new User( Names[5], UsersImagesList[5] ),
		};
        
        public static List<Cleaner> Cleaner = new List<Cleaner> {
            new Cleaner(
                Users[0],
                "5 years",
                "hazardous, household, external",
                true
            ),

            new Cleaner(
                Users[1],
                "5 years",
                "hazardous, household, external",
                true
            ),

            new Cleaner(
                Users[2],
                "5 years",
                "hazardous, household, external",
                true
            ),

            new Cleaner(
                Users[3],
                "5 years",
                "hazardous, household, external",
                true
            ),

            new Cleaner(
                Users[4],
                "5 years",
                "hazardous, household, external",
                true
            ),

            new Cleaner(
                Users[5],
                "5 years",
                "hazardous, household, external",
                true
            )
        };
        
		public static List<User> SmallUserList = Users.GetRange( 0, 2);	
	}
}