namespace Modulo1.Ejercicio3.Utils
{
    public class Name
    {
        public const int MAX_SIZE = 15;

        private string value;

        public Name(string value)
        {
            if (value.Length > Name.MAX_SIZE) {
                throw new System.Exception("Invalid user name");
            }

            this.value = value;
        }
    }
}