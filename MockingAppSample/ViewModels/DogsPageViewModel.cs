using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MockingAppSample.Models;
using Xamarin.Forms;

namespace MockingAppSample.ViewModels
{
    public class DogsPageViewModel: BasePageViewModel
    {
        public ICommand GetDogsCommand { get; set; }
        public ObservableCollection<Dog> Dogs { get; set; }
        public DogsPageViewModel()
        {
            GetDogsCommand = new Command(async()=> await GetDogs());
            GetDogsCommand.Execute(null);
        }

        async Task GetDogs(){
            IsBusy = true;
            var dogs = await Api.GetDogs();
            if(dogs != null){
                Dogs = new ObservableCollection<Dog>(dogs);
            }

            IsBusy = false;
        }
    }
}
