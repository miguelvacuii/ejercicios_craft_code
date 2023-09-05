using System; 
using System.Collections.Generic; 

namespace Modulo1.Ejercicio1
{
    public class User
    {

        public static readonly int[] DELETED_USER_IDS = {22, 34, 1000, 1402};
        // El de readonly es incorrecto (además no la marca como privada)
        // Este listado con el tiempo va a crecer demasiado y debería gestionarse desde base de datos
        // De hecho es una mala práctica, debería hacerse un borrado lógico en base de datos

        public static bool CheckUserHasBeenDeleted(int userId)
        {
            int value = Array.Find(User.DELETED_USER_IDS, (element) => {
                return (element == userId) ? true : false;
            });

            return (value == 0) ? false : true;
        }
    }
}