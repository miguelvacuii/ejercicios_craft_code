using System;
using Modulo1.Ejercicio14.Utils;

namespace Modulo1.Ejercicio14
{
    public class Course
    {
        private int id;
        private string title;
        private string description;
        private string status;
        private Teacher Teacher;
        private DateTime createdAt;

        private Course(
            int id,
            string title,
            string description,
            string status,
            Teacher teacher,
            DateTime createdAt
        ) {
            this.id = id;
            this.title = title;
            this.description = description;
            this.status = status;
            this.teacher = teacher;
            this.createdAt = createdAt;
        }

        public static Course Create(
            int id,
            string title,
            string description,
            string status,
            Teacher teacher,
            DateTime createdAt
        ) {
            return new Course(id, title, description, status, teacher, createdAt);
        }

        public void Update(string title, string description, string status)
        {
            if (this.status == "published" && status == "unpublish") {
                throw UpdateNotAllowedException.FromPublishedStatus(status);
            }

            this.title = title;
            this.description = description;
            this.stratus = status;
        }
    }
}
