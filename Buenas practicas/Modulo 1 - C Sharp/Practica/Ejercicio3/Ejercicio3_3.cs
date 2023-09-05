using System;
using System.Uri;
using Modulo1.Ejercicio3.Utils;

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

        // Deberíamos encapsular estas validaciones en una clase aparte, 
        // Un value object donde se ralizasen las comprobaciones sobre el tipo URI
        // De hecho, el método IsWellFormedUriString nos da una pista sobre esto
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


    // Creamos el value object para describir el tipo Uri en Utils
    // Creamos métodos estáticos con las comprobaciones dentro de él
    // Las llamamos cuando sea necesario
    // Ahora queda mucho más claro y más limpio todo
    public class UriControllerRefactor
    {
        public bool Save(string uri)
        {
            if (!Uri.IsURI(uri))
            {
                return false;
            }

            if (!Uri.IsHTTPS(uri))
            {
                return false;
            }

            //Do something
            return true;
        }
    }
}
