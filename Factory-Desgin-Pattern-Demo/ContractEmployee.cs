using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Desgin_Pattern_Demo
{
    // 'ConcreteProduct' class
    public class ContractEmployee : IEmployee
    {
        public void details()
        {
            Console.WriteLine("This is Temporary employee type object");
        }
    }
}
