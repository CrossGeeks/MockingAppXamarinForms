using System;
using System.Collections.Generic;
using MockingAppSample.ViewModels;
using Xamarin.Forms;

namespace MockingAppSample.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
