using System.Collections.Generic;
using Directos.Modulo1.Ejercicio1.DataBase;
using Directos.Modulo1.Ejercicio1.Service.Converter;
using Directos.Modulo1.Ejercicio1.Model.Course;

namespace Directos.Modulo1.Ejercicio1.UseCase
{
    public class FindCoursesByTitleUseCase
    {
        private MysqlCourseRepository mysqlCourseRepository;

        private CourseResponseConverter courseConverter;

        public FindCoursesByTitleUseCase(MysqlCourseRepository mysqlCourseRepository, CourseResponseConverter courseConverter)
        {
            this.mysqlCourseRepository = mysqlCourseRepository;
            this.courseConverter = courseConverter;
        }

        public List<CourseResponse> Execute(FindCoursesByTitleRequest findCoursesByTitleRequest)
        {
            string title = findCoursesByTitleRequest.Title;

            if (title.Length > 60)
            {
                throw new System.Exception("bad title");
            }

            List<Course> courses = this.mysqlCourseRepository.FindByTitle(title);

            return this.courseConverter.Convert(courses);
        }
    }
}