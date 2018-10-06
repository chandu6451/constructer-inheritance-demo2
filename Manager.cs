using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceDemo2
{
    public class Manager : Employee
    {
        public Manager() : base()
        {
            Console.WriteLine("Manager Default Constructor");
        }

        public Manager(int id, string name, double salary, double comp) : base(id, name, salary)
        {
            Console.WriteLine("Manager Parameterized Constructor");
        }
    }
}
