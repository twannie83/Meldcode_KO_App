﻿using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Meldcode_KO_App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://www.boink.info")));
        }

        public ICommand OpenWebCommand { get; }
    }
}