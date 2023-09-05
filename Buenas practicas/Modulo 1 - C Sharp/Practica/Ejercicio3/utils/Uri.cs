using System;
using System.Uri;Uri.cs

namespace Modulo1.Ejercicio3.Utils
{
    public class Uri {

        // Este nombre podría mejorar
        public static bool IsURI(string value)
        {
            return this.IsWellFormedUriString(value, (int) UriKind.RelativeOrAbsolute);
        }

        // Desarollamos un poco la lógica del validador
        private bool IsWellFormedUriString(string value, int relativeOrAbsolute) {
            if(value.Length > relativeOrAbsolute ) {
                return true;
            }
            return false;
        }

        public static bool IsHTTPS(string value)
        {
            if (value.IndexOf("https") != -1)
            {
                return true;
            }
            return false;
        }
    }
}
