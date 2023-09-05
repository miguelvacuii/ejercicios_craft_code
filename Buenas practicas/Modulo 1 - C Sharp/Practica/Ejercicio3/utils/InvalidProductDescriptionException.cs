using System;

namespace Modulo1.Ejercicio3.Utils
{
    public class InvalidProductDescriptionException : Exception
    {
        // Ya no necesitamos pasar a la clase padre el string formateado porque tenemos excepciones específicas
        // public InvalidProductDescriptionException(string description): base(string.Format("Invalid description: {0}", description)){}
        public InvalidProductDescriptionException(string description): base(description)){}

        // Creamos la excepción específica para max size exceeded
        public static InvalidProductDescriptionException MaximunSizeExceeded()
        {
            return new InvalidProductDescriptionException(
                string.Format(
                    "You have exceeded maximun size {0}",
                    ProductDescriptionRefactor.MAX_SIZE
                )
            );
        }

        // Creamos la excepción específica para description is empty
        public static InvalidProductDescriptionException DescriptionIsEmpty()
        {
            return new InvalidProductDescriptionException(
                string.Format("description is empty")
            );
        }
    }
}