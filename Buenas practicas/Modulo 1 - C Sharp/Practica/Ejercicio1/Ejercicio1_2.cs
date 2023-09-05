using System;

namespace Modulo1.Ejercicio1
{
    public class CourseStatus
    {
        public const string UNPUBLISH_STATUS = "unpublish";
        public const string PUBLISHED_STATUS = "published";
        public const string CLOSED_STATUS = "closed";
        // Uso de constantes es correcto
        // Quizá sería mejor utilizar un ENUM
        // Si no va a usarse desde fuera de la clase debería declararse como private
    }

    public class Course
    {
        private string title;
        private string status;

        public void Update(string title, string status)
        {
            if (status == CourseStatus.CLOSED_STATUS) {
                throw new System.Exception("Course cannot be update");
                // Aquí debería utilizarse una excepción no generica con un estático
            }

            this.title = title;
            this.status = status;
        }
    }
}