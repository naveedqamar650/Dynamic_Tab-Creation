﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomTabViewTest
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

        private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            this.CustomTabsView.ScrollTo(e.CurrentItem, null, ScrollToPosition.Center, true);
        }
    }
}
