namespace Modulo1.Ejercicio1
{
    public class PostDescription
    {
        public const int MAX_SIZE = 1300;

        private string value;

        public PostDescription(string value)
        {
            if (value.Length > PostDescription.MAX_SIZE) {
                throw new System.Exception("Invalid course description");
            }

            this.value = value;
        }
    }
}