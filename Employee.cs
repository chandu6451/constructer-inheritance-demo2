using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceDemo2
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee Default Constructor");
        }

        public Employee(int id, string name, double salary)
        {
            Console.WriteLine("Employee Parameterized Constructor");
        }
    }
}
