using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolApp
{
    class Program
    {
        static void Main()
        {
            //var person = new Person();
            //var person = Person.CreateNew();

            //person.Age = 30;
            //person.FirstName = "Mattias";
            //person.LastName = "Reynaldus";
            //person.IsMale = true;

            //person.AddYears(3);

            //var personService = new PersonService();
            //personService.PrintName(person);

            //Console.ReadKey();
            //Console.WriteLine("Writing People List");

            //var people = personService.MakePeopleList(3);

            //foreach (var p in people)
            //{
            //    personService.PrintName(p);
            //}

            var calculator = new Calculator();
            calculator.RunAdditionSequence();

            Console.ReadKey();
        }


    }

    public class Calculator
    {
        public void RunAdditionSequence()
        {
            Console.WriteLine("Beginning Addition Sequence.");
            Console.WriteLine();
            

            Console.WriteLine("Please enter any number.");
            Console.WriteLine();


            var input1 = Console.ReadKey().KeyChar.ToString();
            //Console.WriteLine(input.KeyChar);
            Console.WriteLine();

            Console.WriteLine("Enter a second number to add.");
            Console.WriteLine();
            var input2 = Console.ReadKey().KeyChar.ToString();
            var int1 = int.Parse(input1);
            var int2 = int.Parse(input2);

            Console.WriteLine();

            Console.WriteLine($"the sum of your numbers is {int1 + int2}");
            Console.WriteLine($"the sum of your numbers is {input1 + input2}");

        }
    }
}
