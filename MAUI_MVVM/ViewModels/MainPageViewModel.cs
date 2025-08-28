
using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUI_MVVM.ViewModels
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
