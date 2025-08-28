using MAUI_MVVM.ViewModels;

namespace MAUI_MVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

}
