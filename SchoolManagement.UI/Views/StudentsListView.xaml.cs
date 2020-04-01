using SchoolManagement.Models;
using SchoolManagement.UI.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StudentsListView : Window
    {
        StudentsViewModel _vm;

        public StudentsListView(StudentsViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
            _vm = viewModel;
        }

        private void Modify_Click(object sender, ExecutedRoutedEventArgs e)
        {            
            StudentEditView wnd = new StudentEditView(new StudentViewModel((Student)dg.SelectedItem));

            wnd.ShowDialog();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            _vm.Students.Remove((Student)dg.SelectedItem);
        }

        private void AlwaysTrue_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewStudent_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Student student = new Student() { FirstName = "Undefined", LastName = "Undefined", RegistrationNumber = "0000000" };

            StudentEditView wnd = new StudentEditView(new StudentViewModel(student));

            if (wnd.ShowDialog() == true)
            {
                _vm.Students.Add(student);
            }
        }
    }

    /// <summary>
    /// Inspiration : https://www.wpf-tutorial.com/commands/implementing-custom-commands/
    /// </summary>
    public static class CustomCommands
    {
        public static readonly RoutedUICommand New = new RoutedUICommand(
                "Nouveau",
                "Nouveau",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.N, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Modify = new RoutedUICommand(
                "Modifier",
                "Modifier",
                typeof(CustomCommands)
            );
    }
}
