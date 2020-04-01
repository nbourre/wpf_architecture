using SchoolManagement.Models;
using SchoolManagement.UI.ViewModels;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentsViewModel _vm;

        public MainWindow(StudentsViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
            _vm = viewModel;
        }

        private void NewRecord_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student() { FirstName = "Undefined", LastName = "Undefined", RegistrationNumber = "0000000" };

            StudentEditView wnd = new StudentEditView(student);

            if (wnd.ShowDialog() == true)
            {
                _vm.Students.Add(student);
            }
        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {            
            StudentEditView wnd = new StudentEditView((Student)dg.SelectedItem);

            wnd.ShowDialog();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            _vm.Students.Remove((Student)dg.SelectedItem);
        }
    }
}
