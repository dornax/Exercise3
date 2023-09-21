using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class PersonHandler : Person
    {
        List<Person> personsList;

        public PersonHandler()
        {
            personsList = new List<Person>();
        }


        public void SetAge(string fName, string lName, int age)
        {
            foreach (var person in personsList)
            {
                if (person.FName == fName && person.LName == lName) person.Age = age;
            }
        }

        public void SetHeight(string fName, string lName, double height)
        {
            foreach (var person in personsList)
            {
                if (person.FName == fName && person.LName == lName)
                {
                    Console.WriteLine($"{person.FName} {person.LName} " +
                        $"height: {person.Height} -> {height}");
                    person.Height = height;
                }
            }
        }

        public void SetWeight(string fName, string lName, double weight)
        {
            foreach (var person in personsList)
            {
                if (person.FName == fName && person.LName == lName)
                {
                    Console.WriteLine($"{person.FName} {person.LName} " +
                        $"weight: {person.Weight} -> {weight}");
                    person.Weight = weight;
                }
            }
        }

        public void WritePersons()
        {
            foreach (var person in personsList)
            {
                Console.WriteLine($"{person.FName} {person.LName} age: {person.Age}" +
                   $" heigth: {person.Height}cm weight: {person.Weight}kg");
            }
        }

        public void RemovePerson(string fName, string lName)
        {
            foreach (var person in personsList)
            {
                if (person.FName == fName && person.LName == lName)
                {
                    Console.WriteLine($"{person.FName} {person.LName} removed");
                    personsList.Remove(person);
                    return;
                }
            }
        }

        public void CreatePerson(int age, string fName, string lName,
            double height, double weight)
        {

            var person = new Person()
            {
                Age = age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight
            };

            personsList.Add(person);
        }
    }
}
