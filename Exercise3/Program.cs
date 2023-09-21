using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Person person = new Person("John", "Smith");
                person.Age = 25;
                Console.WriteLine($"{person.FName} {person.LName} {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}