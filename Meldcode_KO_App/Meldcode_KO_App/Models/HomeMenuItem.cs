﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Meldcode_KO_App.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
		Item
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
