using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Desgin_Pattern_Demo
{
    // 'ConcrteCreator' class
    class Employee : EmployeeFactory
    {
        public override IEmployee Factory(string employeeType)
        {
            switch (employeeType)
            {
                case "PermanentEmployee":
                    return new PermanentEmployee();
                case "TemporaryEmployee":
                    return new ContractEmployee();
                default:
                    throw new ApplicationException(string.Format("This type of employee can not be created"));
            }
        }
    }
}
