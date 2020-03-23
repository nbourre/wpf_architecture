using SchoolManagement.UI.ViewModels;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainWindow _wnd;

        public App()
        {
            MainViewModel vm = new MainViewModel();
            _wnd = new MainWindow(vm);
            _wnd.Show();
        }
    }
}
