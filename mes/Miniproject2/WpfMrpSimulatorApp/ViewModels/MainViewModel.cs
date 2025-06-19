using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMrpSimulatorApp.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        public string _greeting;

        public MainViewModel()
        {
            Greeting = "MRP 공정관리!";
        }

        private string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value);
        }
    }
}
