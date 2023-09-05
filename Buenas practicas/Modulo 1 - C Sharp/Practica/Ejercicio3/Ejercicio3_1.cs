using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.Reflection.Metadata;
using Modulo1.Ejercicio3.Utils;

namespace Modulo1.Ejercicio3
{
    
    /*
    public class SignUpUserUseCase
    {
        public User signUpUser()
        {
            Name name = new Name("Pepe");
            Status status = new Status(Status.ACTIVED_STATUS);
            User user = new User(name, status);

            return user;
        } 
    }
    */
    
    // No es buena práctica instanciar clases directamente
    // Mejor usar un estatico named constructor, es más semántico, descriptivo y limpio
    // Si el status es activo siempre que se crea un usuario nuevo, deberíamos encapsularlo en el named constructor

    public class User {

        // Pasamos a privadas las propiedades de la clase
        private Name name;
        private Status status;
        
        private User(Name name, Status status) {
            this.name = name;
            this.status = status; 
        }

        // Creamos un named constructor
        public static User CreateUser(Name name) {
            // Encapsulamos el status en el named constructor
            Status status = new Status(Status.ACTIVED_STATUS);
            return new User(name, status);
        }

    }

    // Ahora es más limpio y más claro
    public class SignUpUserUseCase
    {
        public User signUpUserRefactor()
        {
            Name username = new Name("Pepe");
            return User.CreateUser(username);
        } 
    }
}