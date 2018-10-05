using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Meldcode_KO_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

		private void goToWebViewPageHandler(object sender, EventArgs e)
		{
			App.Current.MainPage = new MainPage();
		}
	}

	public class PageManager
	{
		public static NavigationPage Init()
		{
			NavigationPage nav = new NavigationPage(new AboutPage());
			return nav;
		}
	}
}