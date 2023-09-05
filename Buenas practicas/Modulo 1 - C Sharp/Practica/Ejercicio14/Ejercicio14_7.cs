using System;
using Modulo1.Ejercicio14.Utils;

namespace Modulo1.Ejercicio14
{
    public class Title
    {
        public const int MAX_SIZE = 15;

        private string value;

        public Title(string value)
        {
            if (value.Length == 0) {
                throw new System.Exception("title is empty");
            }

            if (value.Length > UserName.MAX_SIZE) {
                throw new System.Exception("title cannot be longer than 15 characters");
            }

            this.value = value;
        }
    }
}
