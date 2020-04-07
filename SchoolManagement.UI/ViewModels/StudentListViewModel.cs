using SchoolManagement.Business;
using SchoolManagement.Models;
using SchoolManagement.UI.ViewModels.Commands;
using System.Collections.ObjectModel;
using System.Windows;

namespace SchoolManagement.UI.ViewModels
{
    public class StudentListViewModel : BaseViewModel
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

        public StudentListViewModel()
        {
            initValues();
        }

        private void initValues()
        {
            studentDataService = new StudentDataService();
            Students = new ObservableCollection<Student>(studentDataService.GetAll());
        }

    }
}
