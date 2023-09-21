using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Person person = new Person
                {
                    FName = "John",
                    LName = "Smith"
                };
                PersonHandler personHandler = new PersonHandler();
                personHandler.SetAge(person, 25);

                Console.WriteLine($"{person.FName} {person.LName} age: {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}