using System;
using System.Uri;

namespace Modulo1.Ejercicio3
{
    public class UriController
    {
        public Save(string uri)
        {
            if (!this.IsURI(uri)) {
                return false;
            }        

            if (!this.IsHTTPS(uri)) {
                return false;
            } 

            //Do something   
        }

        private bool IsURI()
        {
            return Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute);
        }

        private bool IsHTTPS()
        {
            if (value.IndexOf("https") != -1) {
                return true;
            }

            return false;
        }
    }
}
