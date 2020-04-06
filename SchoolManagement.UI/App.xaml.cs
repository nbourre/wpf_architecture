using SchoolManagement.UI.ViewModels;
using SchoolManagement.UI.Views;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainWindowView _wnd;

        public App()
        {
            //StudentsViewModel vm = new StudentsViewModel();
            //_wnd = new zOld_MainWindowView(vm);
            _wnd = new MainWindowView();
            _wnd.Show();
        }

    }
}
