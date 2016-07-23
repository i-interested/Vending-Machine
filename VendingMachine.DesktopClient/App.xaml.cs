using System.Windows;
namespace VendingMachine.DesktopClient
{
    using Views;
    using ViewModels;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var vm = new MainWindowView()
            {
                DataContext = new MainWindowViewModel()
            };
            vm.Show();
        }
    }
}
