using System;
using System.Collections.Generic;
using System.Text;

namespace Meldcode_KO_App.Models
{
    public enum MenuItemType
    {
        Menu,
        About,
		WebView
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
