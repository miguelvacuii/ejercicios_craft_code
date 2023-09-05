using System;

namespace Directos.Modulo1.Ejercicio1.Service.Validator
{
    public class UserValidator
    {
        public bool isIdValid(int id)
        {
            return !string.IsNullOrEmpty(id.ToString());
        }

        public bool isNameValid(string name)
        {
            if (name.Length > 15)
            {
                return false;
            }
            else if (name.Length < 3)
            {
                return false;
            }

            return true;
        }

        public bool isEmailValid(string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool isPasswordValid(string password)
        {
            if (password.Length > 15)
            {
                return false;
            }
            else if (password.Length < 3)
            {
                return false;
            }

            return true;
        }
    }
}