﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();

            Manager m1 = new Manager(101, "Robert", 30000, 5000);

            Console.ReadKey();
        }
    }
}
