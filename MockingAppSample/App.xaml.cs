using System;
using System.ComponentModel;
using MockingAppSample.Services;
using MockingAppSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MockingAppSample
{
    public partial class App : Application
    {
        private static IContainer _container;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
          
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
