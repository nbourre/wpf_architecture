using SchoolManagement.Models;
using SchoolManagement.UI.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.UI.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private StudentListViewModel studentsViewModel;

        private BaseViewModel viewModel;
        public BaseViewModel ViewModel { 
            get => viewModel;
            set
            {
                viewModel = value;
                OnPropertyChanged();
            }
        }

        public ModifyCommand DisplayStudentViewCommand { get; set; }
        public ModifyCommand ValidateStudentCommand { get; set; }


        public MainViewModel()
        {
            DisplayStudentViewCommand = new ModifyCommand(DisplayStudentView);
            ValidateStudentCommand = new ModifyCommand(ValidateStudent);

            studentsViewModel = new StudentListViewModel();
            ViewModel = studentsViewModel;
        }

        private void DisplayStudentView()
        {
            ViewModel = new StudentViewModel(this, (ViewModel as StudentListViewModel).SelectedStudent);
        }

        private void ValidateStudent ()
        {
            ViewModel = studentsViewModel;
        }

        public void ComeBack()
        {
            ViewModel = studentsViewModel;
        }

    }
}
