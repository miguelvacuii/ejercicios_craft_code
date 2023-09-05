using System;
using Modulo1.Ejercicio3.Utils;

namespace Modulo1.Ejercicio3
{
    public class ProductDescription
    {
        // Si no se usa fuera debería ser privado
        public const int MAX_SIZE = 300;
        private string value;

        public ProductDescription(string value)
        {
            // Cada excepcion deberían ir encapsulada en un estático específico
            // No es buena práctica crear las excepciones directamente en la clase
            if (value.Length == 0) {
                throw new InvalidProductDescriptionException("description is empty");
            }

            if (value.Length > ProductDescription.MAX_SIZE) {
                throw new InvalidProductDescriptionException("Invalid description");
            }

            this.value = value;
        }
    }

    public class ProductDescriptionRefactor
    {
        private const int MAX_SIZE = 300;
        private string value;

        public string ProductDescription(string value)
        {
            // Ahora lanzamos las excepciones específicas 
            // que hemos creado como estáticos en utils
            if (value.Length == 0)
            {
                throw InvalidProductDescriptionException.DescriptionIsEmpty();
            }

            if (value.Length > ProductDescriptionRefactor.MAX_SIZE)
            {
                throw InvalidProductDescriptionException.MaximunSizeExceeded();
            }

            return this.value = value;
        }
    }
}