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

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {

            var person = new Person()
            {
                Age = age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight
            };

            return person;
        }
    }
}
