using SchoolManagement.Models;

namespace SchoolManagement.UI.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        private Student student;

        public Student Student {
            get => student;
            set
            {
                student = value;
                OnPropertyChanged();
            }
        }

        public StudentViewModel(Student student)
        {
            Student = student;
        }
    }
}
