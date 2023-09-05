using System.Collections.Generic;
using Directos.Modulo1.Ejercicio1.UseCase;

namespace Directos.Modulo1.Ejercicio1.Controller
{
    public class CourseController
    {
        private FindCoursesByTitleUseCase findCoursesByTitleUseCase;

        public CourseController(FindCoursesByTitleUseCase findCoursesByTitleUseCase)
        {
            this.findCoursesByTitleUseCase = findCoursesByTitleUseCase;
        }
        public List<CourseResponse> get()
        {
            return this.findCoursesByTitleUseCase.Execute(new FindCoursesByTitleRequest(
                "Craft Code Best Practices"
            ));
        }
    }
}