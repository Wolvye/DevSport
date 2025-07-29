using DevSport.MVVM.Models;
using DevSport.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevSport.MVVM.Commands
{




    public class WorkoutCommands : ICommand
    {
        private ViewModelDevSport _viewModel;
        public WorkoutCommands(ViewModelDevSport viewModel)
        {
            _viewModel = viewModel;

        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            var workout = new WorkoutActivity
            {
                Name = _viewModel.Name,
                Repetitions = _viewModel.Repetitions,
                Weight = _viewModel.Weight,
                Date = _viewModel.Date,

            }; Console.WriteLine($"Name: {_viewModel.Name}," +
                $" Reps: {_viewModel.Repetitions}," +
                $" Weight: {_viewModel.Weight}," +
                $" Date: {_viewModel.Date}");
        }

    }
}
