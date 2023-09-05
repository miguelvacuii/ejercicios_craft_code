using Directos.Modulo1.Ejercicio1.UseCase;
using Directos.Modulo1.Ejercicio1.Model.Course;
using System.Collections.Generic;

namespace Directos.Modulo1.Ejercicio1.Service.Converter
{
    public class CourseResponseConverter
    {
        public List<CourseResponse> Convert(List<Course> courses)
        {
            List<CourseResponse> courseResponse = new List<CourseResponse>();

            foreach (var course in courses)
            {
                courseResponse.Add(new CourseResponse(
                    course.Id,
                    course.Title
                ));
            }

            return courseResponse;
        }
    }
}