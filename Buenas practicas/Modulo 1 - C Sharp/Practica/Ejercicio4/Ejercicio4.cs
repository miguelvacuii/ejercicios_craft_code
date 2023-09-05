using Internal;
using Modulo1.Ejercicio4;

namespace Modulo1.Ejercicio4
{

    // Named Constructor
    public class Employee
    {
        private Employee (
            EmployeeId id,
            EmployeeName name,
            EmployeeEmail email,
            Employee status
        ) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.status = status;
        }
        
        public static Employee SignUp(
            EmployeeId id,
            EmployeeName name,
            EmployeeEmail email
        ) {
            EmployeeStatus status = new EmployeeStatus(EmployeeStatus.ACTIVE);
            Employee employee = new Employee(id, name, email, status);
            return employee;
        }
    }


    // Helper
    static class Operaciones {
        public static int Sumar(int value1, int value2) {
            return value1 + value2
        }

        public static int Restar(int value1, int value2) {
            return value1 - value2
        }
    }


    // Excepciones
    public class EmployeeNotFoundException : ResourceNotFoundException
    {
        public EmployeeNotFoundException (String message): base(message){}
        
        public static EmployeeNotFoundException FormId(EmployeeId id)
        {
            return new EmployeeNotFoundException(
                string.Format(
                    "Employee has not been found with id {0}",
                    id.GetValue()
                )
            )
        }
        public static EmployeeNotFoundException FormName(EmployeeName name)
        {
            return new EmployeeNotFoundException(
                string.Format(
                    "Employee has not been found with name {0}",
                    name.GetValue()
                )
            )
        }
    }
}