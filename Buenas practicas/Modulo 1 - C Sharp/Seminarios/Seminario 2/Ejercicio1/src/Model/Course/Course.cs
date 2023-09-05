namespace Directos.Modulo1.Ejercicio1.Model.Course
{
    public class Course
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public Course(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        //TODO Logic
    }
}