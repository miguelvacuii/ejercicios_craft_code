using Directos.Modulo1.Ejercicio1.UseCase;

namespace Directos.Modulo1.Ejercicio1.Controller
{
    public class UserController
    {
        private SignUpUserUseCase signUpUserUseCase;

        public UserController(SignUpUserUseCase signUpUserUseCase)
        {
            this.signUpUserUseCase = signUpUserUseCase;
        }
        public UserResponse post()
        {
            return this.signUpUserUseCase.Execute(new SignUpUserRequest(
                1,
                "Agustin",
                "acastro@craft-code.com",
                "12345678"
            ));
        }
    }
}