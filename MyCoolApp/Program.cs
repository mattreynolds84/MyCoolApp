using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Age = 30;
            person.FirstName = "Mattias";
            person.LastName = "Reynaldus";

            var personService = new PersonService();
            personService.PrintName(person);

            Console.ReadKey();
        }
    }
}
