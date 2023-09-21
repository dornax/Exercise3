using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Person person = new Person();

                PersonHandler personHandler = new PersonHandler();
                person = personHandler.CreatePerson(25, "John", "Smith", 180, 75);

                Console.WriteLine($"{person.FName} {person.LName} age: {person.Age}" +
                    $" heigth: {person.Height}cm weight: {person.Weight}kg");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}