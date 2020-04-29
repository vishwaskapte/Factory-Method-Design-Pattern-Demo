using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Desgin_Pattern_Demo
{
    // 'ConcreteProduct' class
    public class PermanentEmployee : IEmployee
    {
        public void details()
        {
            Console.WriteLine("This is permanent employee type object");
        }
    }
}
