using Directos.Modulo1.Ejercicio1.UseCase;
using Directos.Modulo1.Ejercicio1.Model.User;

namespace Directos.Modulo1.Ejercicio1.Service.Converter
{
    public class UserResponseConverter
    {
        public UserResponse Convert(User user)
        {
            return new UserResponse(user.Id, user.Name, user.Email);
        }
    }
}