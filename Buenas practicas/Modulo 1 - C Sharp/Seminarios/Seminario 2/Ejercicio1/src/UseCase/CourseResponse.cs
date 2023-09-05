namespace Directos.Modulo1.Ejercicio1.UseCase
{
    public class CourseResponse : IResponse
    {
        public int Id;

        public string Title;

        public CourseResponse(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }
    }
}