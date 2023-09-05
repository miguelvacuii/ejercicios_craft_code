using System;
namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Course course = new Course()
            {
                Id = 1,
                Title = "good practices",
                Description = "learn best coding practices for programming",
                Status = "published",
                TeacherName = "Rubén",
                TeacherAge = 38,
                CreatedAt = "2018-05-14 00:00:55"
            };

            Console.WriteLine(course.TeacherAge);

            

            //return books;
        }
    }
}
