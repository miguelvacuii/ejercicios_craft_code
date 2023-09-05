using System;

namespace Modulo1.Ejercicio14.Utils
{
    public class UpdateNotAllowedException : Exception
    {
        public UpdateNotAllowedException(string message): base(message){}

        public static void FromPublishedStatus(string status)
        {
            throw new UpdateNotAllowedException(string.Format("'the course can not be updated from published to {0}", status));
        }
    }
}
