using SchoolManagement.UI.ViewModels;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(StudentsViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
