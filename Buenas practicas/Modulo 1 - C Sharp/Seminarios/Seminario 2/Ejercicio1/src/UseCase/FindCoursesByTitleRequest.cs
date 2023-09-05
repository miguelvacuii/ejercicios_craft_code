namespace Directos.Modulo1.Ejercicio1.UseCase
{
    public class FindCoursesByTitleRequest
    {
        public string Title;
        public FindCoursesByTitleRequest(string title)
        {
            this.Title = title;
        }
    }
}