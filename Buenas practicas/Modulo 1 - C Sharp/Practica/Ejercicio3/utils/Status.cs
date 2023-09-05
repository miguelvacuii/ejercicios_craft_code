namespace Modulo1.Ejercicio3.Utils
{
    public class Status
    {
        public const string ACTIVED_STATUS = "active";
        public const string DELETED_STATUS = "deleted";

        private string value;

        public Status(string value)
        {
            if (value != Status.ACTIVED_STATUS && value != Status.DELETED_STATUS) {
                throw new System.Exception("Invalid user status");
            }

            this.value = value;
        }
    }
}