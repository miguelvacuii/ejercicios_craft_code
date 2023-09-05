namespace Modulo1.Ejercicio1
{
    public class PostDescription
    {
        public const int MAX_SIZE = 1300;
        // El uso de constantes es correcto
        // Si no va a usarse desde fuera de la clase debería estar en private

        private string value;

        public PostDescription(string value)
        {
            if (value.Length > PostDescription.MAX_SIZE) {
                throw new System.Exception("Invalid course description");
                // Aquí debería utilizarse una excepción no generica con un estático
            }

            this.value = value;
        }
    }
}