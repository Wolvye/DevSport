using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSport.MVVM.Models
{
    public class WorkoutActivity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Repetitions { get; set; }
        public double Weight { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
       
    }
}
