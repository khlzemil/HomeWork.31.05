using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._31._05
{
    internal class Person
    {

        public static int stAge;

        public int age;
        public Person()
        {
            stAge++;
            age = stAge;
        }
        
    }
}
