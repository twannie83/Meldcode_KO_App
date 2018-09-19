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
	public partial class WebViewPage : ContentView
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}

		public static implicit operator Page(WebViewPage v)
		{
			throw new NotImplementedException();
		}
	}
}