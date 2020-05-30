/*
* VERSION - 2.0.0
*/

using System;
using Domain;
using Database;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SchoolDBContext())
            {
                var studentsDB = context.students;
                Console.WriteLine("Fetching Data from DB - ");
                foreach(var s in studentsDB)
                {
                    Console.WriteLine("Student - id = " + s.StudentId + " name = " +s.Name);
                }
                Console.WriteLine("End!");
            }
        }
    }
}
