using System;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student
                {
                    Name = "John Doe"
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully.");
            Console.ReadLine();
        }
    }
}
