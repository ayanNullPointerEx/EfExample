using System;
using Domain;
using Database;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                StudentId = 2,
                Name = "Ayan"
            };
            Console.WriteLine("Before saving data to DB - ");
            Console.WriteLine("Student - id = " + student.StudentId + " name = " +student.Name);
            using(var context = new SchoolContext())
            {
                var studentsDB = context.students;
                studentsDB.Add(student);
                context.SaveChanges();
                Console.WriteLine("Entity saved in DB!\n Fetching data from DB");
                foreach(var s in studentsDB)
                {
                    Console.WriteLine("Student - id = " + s.StudentId + " name = " +s.Name);
                }
                Console.WriteLine("End!");
            }
        }
    }
}
