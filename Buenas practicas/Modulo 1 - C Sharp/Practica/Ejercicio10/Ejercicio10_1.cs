using System;

namespace Modulo1.Ejercicio10
{
    public class Employee
    {
        private int id;
        private string name;
        protected int experience; 

        public abstract int Salary();
    }

    public class Trainee : Employee
    {
        private const int BASE_SALARY = 1000;

        public override int Salary()
        {
            return this.experience * Trainee.BASE_SALARY;
        }
    }

    public class Junior : Employee
    {
        private const int BASE_SALARY = 2000;

        public override int Salary()
        {
            return this.experience * Junior.BASE_SALARY;
        }
    }

    public class Senior : Employee
    {
        private const int BASE_SALARY = 3000;
        
        public override int Salary()
        {
            return this.experience * Senior.BASE_SALARY;
        }
    }
}
