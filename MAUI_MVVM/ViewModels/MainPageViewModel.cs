
using CommunityToolkit.Mvvm.ComponentModel;

namespace CameraApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string name;

        public MainPageViewModel()
        {
            Name = "Oláh Levente";
        }
    }
}
