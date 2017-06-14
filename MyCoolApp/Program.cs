using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolApp
{
    class Program
    {
        public int HeightInInches { get; set; }
        static void Main(string[] args)
        {
            var person = new MattsClass(33, "Matt", "Reynolds");

            var otherPerson = new MattsClass();
            otherPerson.Age = 40;
            otherPerson.FirstName = "Matt";
            otherPerson.LastName = "HollandBuger";

            person.PrintName();
            otherPerson.PrintName();

            
            Console.ReadKey();
        }

        public static void DoSomethingCool()
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }

    public class MattsClass
    {
        public MattsClass(int age, string firstName, string lastName)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public MattsClass()
        {
            
        }

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DisplayName
        {
            //get { return FirstName + " " + LastName + " " + Age + " Robby sux at everything"; }
            get { return $"{FirstName} {LastName} {Age} Robby sux at tekken"; }
        }

        public void PrintName()
        {
            Console.WriteLine(DisplayName);
        }
    }
}
