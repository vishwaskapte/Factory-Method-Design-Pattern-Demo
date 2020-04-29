using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Desgin_Pattern_Demo
{
    // 'Creator' abstract class
    abstract class EmployeeFactory
    {
        public abstract IEmployee Factory(string employeeType);
    }
}
