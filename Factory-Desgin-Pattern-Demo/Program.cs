using System;

namespace Factory_Desgin_Pattern_Demo
{
    // factory method design pattern demo
    // calling class/ client
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeFactory EmployeeFactory = new Employee();

            IEmployee permanentEmployee = EmployeeFactory.Factory("PermanentEmployee");
            permanentEmployee.details();

            IEmployee TemporaryEmployee = EmployeeFactory.Factory("TemporaryEmployee");
            TemporaryEmployee.details();

            Console.ReadLine();
        }
    }
}
