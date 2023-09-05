using System;

namespace Modulo1.Ejercicio10
{
    public class Employee
    {
        private int id;
        private string name;
        protected int experience; 

        public abstract bool IsOnCall();
    }

    public class Trainee : Employee
    {
        public override bool IsOnCall()
        {
            return false;
        }
    }

    public class Junior : Employee
    {
        public override bool IsOnCall()
        {
            return false;
        }
    }

    public class Senior : Employee
    {
        public override bool IsOnCall()
        {
            return true;
        }
    }
}
