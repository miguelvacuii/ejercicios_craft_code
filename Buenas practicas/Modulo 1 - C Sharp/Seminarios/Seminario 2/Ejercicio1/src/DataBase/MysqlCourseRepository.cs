using System.Collections.Generic;
using Directos.Modulo1.Ejercicio1.Model.Course;

namespace Directos.Modulo1.Ejercicio1.DataBase
{
    public class MysqlCourseRepository
    {
        public List<Course> FindByTitle(string title)
        {
            return new List<Course>() {
                new Course(1, "ss"),
                new Course(2, "ss")
            };
        }
    }
}