using System;
using Directos.Modulo1.Ejercicio1.UseCase;
using Directos.Modulo1.Ejercicio1.Controller;
using Directos.Modulo1.Ejercicio1.Service.Validator;
using Directos.Modulo1.Ejercicio1.Service.Converter;
using Directos.Modulo1.Ejercicio1.DataBase;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController(
                new SignUpUserUseCase(
                    new UserValidator(),
                    new MysqlUserRepository(),
                    new UserResponseConverter()
                )
            );

            UserResponse userResponse = userController.post();
            Console.WriteLine("######## User ########");
            Console.WriteLine(userResponse.Id);
            Console.WriteLine(userResponse.Name);

            CourseController courseController = new CourseController(
                new FindCoursesByTitleUseCase(
                    new MysqlCourseRepository(),
                    new CourseResponseConverter()
                )
            );

            List<CourseResponse> courseReponse = courseController.get();

            Console.WriteLine("######## Course ########");
            foreach (CourseResponse course in courseReponse)
            {
                Console.WriteLine(course.Id);
                Console.WriteLine(course.Title);
            }
        }
    }
}
