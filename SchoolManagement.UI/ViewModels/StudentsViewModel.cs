using SchoolManagement.Business;
using SchoolManagement.Models;
using SchoolManagement.UI.ViewModels.Commands;
using System.Collections.ObjectModel;
using System.Windows;

namespace SchoolManagement.UI.ViewModels
{
    public class StudentsViewModel : BaseViewModel
    {
        StudentDataService studentDataService;
        private ObservableCollection<Student> students;
        private Student selectedStudent;

        public ModifyCommand ModifyStudentCommand { get; set; }

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

        public StudentsViewModel()
        {
            initValues();

            ModifyStudentCommand = new ModifyCommand(ModifyStudent);
        }

        private void initValues()
        {
            studentDataService = new StudentDataService();
            Students = new ObservableCollection<Student>(studentDataService.GetAll());
        }

        private void ModifyStudent()
        {

        }
    }
}
