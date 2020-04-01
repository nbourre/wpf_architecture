using SchoolManagement.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for StudentModify.xaml
    /// </summary>
    public partial class StudentEditView : Window, INotifyPropertyChanged
    {
        Student student;

        public Student Student { 
            get => student;
            set { 
                student = value;
                OnPropertyChanged();
            } 
        }

        public StudentEditView(Student _student)
        {
            InitializeComponent();

            Student = _student;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Validate_Click(object sender, RoutedEventArgs e)
        {
            Student.FirstName = txtFirstName.Text;
            Student.LastName = txtLastName.Text;
            Student.RegistrationNumber = txtRegistrationNumber.Text;

            this.DialogResult = true;

            this.Close();

        }
    }
}
