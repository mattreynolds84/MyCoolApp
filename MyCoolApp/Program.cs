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
            var person = new MattsClass(33, "Matt", "Reynolds");
            
            var otherPerson = new MattsClass();
            otherPerson.Age = 40;
            otherPerson.FirstName = "Matt";
            otherPerson.LastName = "HollandBuger";

            person.PrintName();
            otherPerson.PrintName();
            
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
            var i = DateTime.Now;
            DateTime[] dates = {DateTime.Now.AddDays(2), DateTime.Now.AddDays(4) };
            
            this.FavoriteNumbers = new List<DateTime>(dates);
            var numberOfFavorites = this.FavoriteNumbers.Count();

            this.FavoriteNumbers.Add(i);

            this.FavoriteNumbers.Remove(i);
            var x = 0;
        }

        public MattsClass():this(0, "", "")
        {
        }

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<DateTime> FavoriteNumbers { get; set; }

        public string DisplayName
        {
            get { return $"{FirstName} {LastName}: {Age} Robby sux at tekken"; }
        }

        public void PrintName()
        {
            Console.WriteLine(DisplayName);
        }


    }
}
