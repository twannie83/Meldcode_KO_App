using Meldcode_KO_App.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Meldcode_KO_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

			//Add About Button to toolbar
			var settings = new ToolbarItem
			{
				Text = "Over",
				Command = new Command(this.pageToAbout),

			};

			this.ToolbarItems.Add(settings);


			MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Menu, (NavigationPage)Detail);


        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Menu:
                        MenuPages.Add(id, new NavigationPage(new MenuPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
				}
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
		void pageToAbout()
		{
			App.Current.MainPage = new AboutPage();
		}

		public class PageManager
		{
			public static NavigationPage Init()
			{
				NavigationPage nav = new NavigationPage(new MainPage());
				return nav;
			}
		}

	}
}