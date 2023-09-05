namespace Directos.Modulo1.Ejercicio1.UseCase
{
    public class SignUpUserRequest
    {
        public int Id;
        public string Name;
        public string Email;
        public string Password;

        public SignUpUserRequest(int id, string name, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }
    }
}