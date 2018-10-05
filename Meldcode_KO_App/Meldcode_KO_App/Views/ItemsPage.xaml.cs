using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Meldcode_KO_App.Models;
using Meldcode_KO_App.Views;
using Meldcode_KO_App.ViewModels;

namespace Meldcode_KO_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            App.Current.MainPage = new MainPage(); 

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
			App.Current.MainPage = new AboutPage();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
		public class PageManager
		{
			public static NavigationPage Init()
			{
				NavigationPage nav = new NavigationPage(new ItemsPage());
				return nav;
			}
		}
	}
}