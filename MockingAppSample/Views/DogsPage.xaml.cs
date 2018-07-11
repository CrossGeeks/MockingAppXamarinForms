using System;
using System.Collections.Generic;
using MockingAppSample.ViewModels;
using Xamarin.Forms;

namespace MockingAppSample.Views
{
    public partial class DogsPage : ContentPage
    {
        public DogsPage()
        {
            InitializeComponent();
            BindingContext = new DogsPageViewModel();

           
        }
    }
}
