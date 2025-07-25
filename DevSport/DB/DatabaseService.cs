using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using DevSport.MVVM.Models;
namespace DevSport.DB
{
    public class DatabaseService
    {
        public async Task DBConnection()
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "DevSport.db");
            var db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<WorkoutActivity>();
            Console.WriteLine("Table created!");
        }

        public static void AddLesson(SQLiteConnection db, string name, int rep, double weight)
        {
            var lesson = new WorkoutActivity()
            {
               Name = name,
               Repetitions = rep,
               Weight = weight,


            };
            db.Insert(lesson);
            Console.WriteLine("Added", lesson.Name, lesson.Repetitions, lesson.Weight);
        }
    }
}
