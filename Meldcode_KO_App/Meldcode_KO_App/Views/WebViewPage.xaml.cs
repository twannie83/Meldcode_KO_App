using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Meldcode_KO_App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage()
		{
			Label lbl_header = new Label
			{
				Text = "WebView",
				HorizontalOptions = LayoutOptions.Center
			};
			WebView webview = new WebView
			{
				Source = "https://meldcodekmko.nl",
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			this.Content = new StackLayout
			{
				Children = {
					 webview
				}
			};

		}
		public class PageManager
		{
			public static NavigationPage Init()
			{
				NavigationPage nav = new NavigationPage(new WebViewPage());
				return nav;
			}
		}
	}
}