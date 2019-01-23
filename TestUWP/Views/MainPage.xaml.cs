using System.Diagnostics;
using TestUWP.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TestUWP {
    public sealed partial class MainPage : Page {
        #region Закрытые поля
        private readonly MainPageViewModel viewModel = new MainPageViewModel();
        #endregion

        public MainPage() {
            InitializeComponent();
            DataContext = this.viewModel;
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e) {
            Debug.WriteLine("MainPage_Loaded");
        }
    }
}
