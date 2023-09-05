using System;

namespace Modulo1.Ejercicio14
{
    public class CourseStatus
    {
        public const string PUBLISHED_STATUS = "published";
        public const string CLOSED_STATUS = "closed";

        private string value;

        public CourseStatus(string value)
        {
            if (value != CourseStatus.PUBLISHED_STATUS && value != CourseStatus.CLOSED_STATUS) {
                throw new System.Exception("Invalid user status");
            }

            this.value = value;
        }
    }
}
