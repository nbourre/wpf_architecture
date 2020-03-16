using SchoolManagement.Business;
using SchoolManagement.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        StudentDataService studentDataService;
        private ObservableCollection<Student> students;
        private Student selectedStudent;

        public ObservableCollection<Student> Students
        {
            get => students;
            set
            {
                students = value;
                OnPropertyChanged();
            }
        }

        public Student SelectedStudent 
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;
                OnPropertyChanged();
            }

        }

        public MainWindow()
        {
            InitializeComponent();

            initValues();

        }

        private void initValues()
        {
            studentDataService = new StudentDataService();
            Students = new ObservableCollection<Student>(studentDataService.GetAll());
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void NewItem_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student
            {
                RegistrationNumber = "0000000",
                FirstName = "To be defined",
                LastName = "To be defined",
            };

            Students.Add(student);
            SelectedStudent = student;

        }
    }
}
