namespace Directos.Modulo1.Ejercicio1.UseCase
{
    public class UserResponse : IResponse
    {
        public int Id;

        public string Name;
        public string Email;

        public UserResponse(int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }
    }
}