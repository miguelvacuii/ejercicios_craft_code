using Modulo1.Ejercicio3.Utils;

namespace Modulo1.Ejercicio3
{
    public class ProductDescription
    {
        public const int MAX_SIZE = 300;
        private string value;

        public ProductDescription(string value)
        {
            if (value.Length == 0) {
                throw new InvalidProductDescriptionException("description is empty");
            }

            if (value.Length > ProductDescription.MAX_SIZE) {
                throw new InvalidProductDescriptionException("Invalid description");
            }

            this.value = value;
        }
    }
}