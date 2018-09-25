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
				Source = "https://meldcodeko.wordpress.com/stappenplan-meldcode-kindermishandeling",
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			this.Content = new StackLayout
			{
				Children = {
					 webview
				}
			};

		}
	}
}