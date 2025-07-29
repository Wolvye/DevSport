using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevSport.MVVM.Commands;


namespace DevSport.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]



    public class ViewModelDevSport
    {

        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Repetitions { get; set; }
        public double Weight { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICommand SaveWorkoutCommand { get; }

        public ViewModelDevSport()
        {
            SaveWorkoutCommand = new WorkoutCommands(this);
        }

    }
}
