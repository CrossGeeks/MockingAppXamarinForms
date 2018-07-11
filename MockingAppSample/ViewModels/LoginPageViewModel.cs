using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MockingAppSample.Models;
using MockingAppSample.Views;
using Xamarin.Forms;

namespace MockingAppSample.ViewModels
{
    public class LoginPageViewModel: BasePageViewModel
    {
        public ICommand LoginCommand { get; set; }
        public User User { get; set; } = new User();
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () => await DoLogin());
        }

        async Task DoLogin()
        {
            IsBusy = true;
            var isValid = await Api.LoginUser(User);
            IsBusy = false;

            if (isValid)
            {
                //Not the correct way to do the navigation 
                await App.Current.MainPage.Navigation.PushAsync(new DogsPage());
            }else{
                await App.Current.MainPage.DisplayAlert("Error", "User is not valid", "Ok");
            }

        }
    }
}
