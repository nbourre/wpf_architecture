using SchoolManagement.UI.ViewModels;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for StudentModify.xaml
    /// </summary>
    public partial class StudentEditView : Window
    {
        StudentViewModel vm;

        public StudentEditView(StudentViewModel _vm)
        {
            InitializeComponent();

            vm = _vm;
            this.DataContext = vm;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void Validate_Click(object sender, RoutedEventArgs e)
        {
            vm.Student.FirstName = txtFirstName.Text;
            vm.Student.LastName = txtLastName.Text;
            vm.Student.RegistrationNumber = txtRegistrationNumber.Text;

            this.DialogResult = true;

            this.Close();

        }
    }
}
