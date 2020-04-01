using SchoolManagement.UI.ViewModels;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        StudentsListView _wnd;

        public App()
        {
            StudentsViewModel vm = new StudentsViewModel();
            _wnd = new StudentsListView(vm);
            _wnd.Show();
        }
    }
}
