using EntityFrameworkApp.DatabaseContext;
using EntityFrameworkApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = GetById(3);
           student.RegNo  = "003";

            bool isUpdated = Update(student);


            if(isUpdated)
            {
                Console.WriteLine("Successfully Saved!");
            }
            else
            {
                Console.WriteLine("Insertion Failed!");
            }



        }

        private static bool Update(Student student)
        {
            TrainingManagementDbContext db = new TrainingManagementDbContext();
            db.Students.Attach(student);

            db.Entry(student).State = EntityState.Deleted;

            return db.SaveChanges() > 0;


        }

        public static Student GetById(int id)
        {
            TrainingManagementDbContext db = new TrainingManagementDbContext();
            var student = db.Students.FirstOrDefault(c => c.Id == id);

            return student;

        }
    }
}
