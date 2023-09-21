using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PersonHandler handler = new PersonHandler();

                handler.CreatePerson(25, "John", "Smith", 180, 75);
                handler.CreatePerson(25, "Ana", "Smith", 180, 70);
                handler.CreatePerson(30, "George", "Scott", 185, 85);

                handler.WritePersons();

                handler.SetWeight("John", "Smith", 80);

                handler.WritePersons();

                handler.RemovePerson("George", "Scott");

                handler.WritePersons();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}