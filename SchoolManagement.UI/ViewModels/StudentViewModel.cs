using SchoolManagement.Models;
using SchoolManagement.UI.ViewModels.Commands;

namespace SchoolManagement.UI.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        BaseViewModel _parentVM;
        private Student student;
        private Student _emptyStudent = new Student();

        public Student Student {
            get => student;
            set
            {
                student = value;
                OnPropertyChanged();
            }
        }

        public Student CacheStudent { get; set; }

        public CancelCommand CancelCommand { get; set; }

        public StudentViewModel(BaseViewModel parentVM, Student student)
        {
            _parentVM = parentVM;

            if (student == null)
                Student = _emptyStudent;
            else
                Student = student;

            CacheStudent = new Student() {
                FirstName = Student.FirstName, 
                LastName = Student.LastName, 
                RegistrationNumber = Student.RegistrationNumber, 
                StudentId = Student.StudentId 
            };

            CancelCommand = new CancelCommand(CancelModification);

        }

        private void CancelModification()
        {
            Student.FirstName = CacheStudent.FirstName;
            Student.LastName = CacheStudent.LastName;
            Student.RegistrationNumber = CacheStudent.RegistrationNumber;
            Student.StudentId = CacheStudent.StudentId;

            (_parentVM as MainViewModel).ComeBack();
        }
    }
}
