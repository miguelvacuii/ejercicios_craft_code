using Directos.Modulo1.Ejercicio1.Service.Validator;
using Directos.Modulo1.Ejercicio1.DataBase;
using Directos.Modulo1.Ejercicio1.Service.Converter;
using Directos.Modulo1.Ejercicio1.Model.User;

namespace Directos.Modulo1.Ejercicio1.UseCase
{
    public class SignUpUserUseCase
    {
        private UserValidator userValidator;
        private MysqlUserRepository mysqlUserRepository;

        private UserResponseConverter userConverter;

        public SignUpUserUseCase(UserValidator userValidator, MysqlUserRepository mysqlUserRepository, UserResponseConverter userConverter)
        {
            this.userValidator = userValidator;
            this.mysqlUserRepository = mysqlUserRepository;
            this.userConverter = userConverter;
        }

        public UserResponse Execute(SignUpUserRequest request)
        {
            int id = request.Id;
            string name = request.Name;
            string email = request.Email;
            string password = request.Password;

            if (!this.userValidator.isIdValid(id))
            {
                throw new System.Exception("invalid id");
            }

            if (!this.userValidator.isNameValid(name))
            {
                throw new System.Exception("invalid name");
            }

            if (!this.userValidator.isEmailValid(email))
            {
                throw new System.Exception("invalid email");
            }

            if (!this.userValidator.isPasswordValid(password))
            {
                throw new System.Exception("invalid password");
            }

            User user = new User(id, name, email, password);

            this.mysqlUserRepository.Save(user);

            return this.userConverter.Convert(user);
        }
    }
}