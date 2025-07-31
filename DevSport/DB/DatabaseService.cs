using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using DevSport.MVVM.Models;
using System.Data.Common;
namespace DevSport.DB
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _connection;
        public DatabaseService() //Konstruktor
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "DevSport.db");
            _connection = new SQLiteAsyncConnection(databasePath);
        }
        public async Task InitializeAsync()
        {
            await _connection.CreateTableAsync<WorkoutActivity>();
        }

        public async Task AddLessonAsync(string name, int rep, double weight)
        {
            
            var lesson = new WorkoutActivity()
            {
                Name = name,
                Repetitions = rep,
                Weight = weight,


            };
            await _connection.InsertAsync(lesson);
            Console.WriteLine("Added", lesson.Name, lesson.Repetitions, lesson.Weight);
        }
    }
}
