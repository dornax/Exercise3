using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class PersonHandler : Person
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
    }
}

