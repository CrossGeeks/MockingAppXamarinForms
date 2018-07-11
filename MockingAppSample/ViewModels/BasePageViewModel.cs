using System;
using System.ComponentModel;
using MockingAppSample.Services;

namespace MockingAppSample.ViewModels
{
    public class BasePageViewModel : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }
        public IApiManager Api { get; set; }

        public BasePageViewModel()
        {
#if MOCK
             Api= new ApiMockManager();
#else
            Api = new ApiManager();
#endif
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
