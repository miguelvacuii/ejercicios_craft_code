using System;

namespace Modulo1.Ejercicio3.Utils
{
    public class InvalidProductDescriptionException : Exception
    {
        public InvalidProductDescriptionException(string description): base(string.Format("Invalid description: {0}", description))
        {

        }
    }
}