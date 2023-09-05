using System;

namespace Modulo1.Ejercicio1
{
    public class CourseStatus
    {
        public const string UNPUBLISH_STATUS = "unpublish";
        public const string PUBLISHED_STATUS = "published";
        public const string CLOSED_STATUS = "closed";
    }

    public class Course
    {
        private string title;
        private string status;

        public void Update(string title, string status)
        {
            if (status == CourseStatus.CLOSED_STATUS) {
                throw new System.Exception("Course cannot be update");
            }

            this.title = title;
            this.status = status;
        }
    }
}