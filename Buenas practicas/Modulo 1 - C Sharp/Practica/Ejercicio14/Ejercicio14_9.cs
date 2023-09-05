using System;
using Modulo1.Ejercicio14.Utils;

namespace Modulo1.Ejercicio14
{
    public class UserName
    {
        public const int MAX_SIZE = 15;

        private string value;

        public UserName(string value)
        {
            if (value.Length == 0) {
                InvalidUserNameException.FromEmpty();
            }

            if (value.Length > UserName.MAX_SIZE) {
                InvalidUserNameException.FromMaxLength();
            }

            this.value = value;
        }
    }
}
