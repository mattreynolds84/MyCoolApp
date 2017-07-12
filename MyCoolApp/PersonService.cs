using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolApp
{
    public class PersonService
    {
        public void PrintName(Person person)
        {
            if (person.Age != 31 && !person.IsMale)
            {
                person.IsMale = true;
            }
            else
            {
                person.IsMale = false;
            }

            Console.WriteLine(person.DisplayName);
        }

        public List<Person> MakePeopleList(int listCount)
        {
            //do something logically here
            return MakePeopleListPrivate(listCount);
        }

        private List<Person> MakePeopleListPrivate(int listCount)
        {
            var results = new List<Person>();

            for (int i = 0; i < listCount; i++)
            {
                var person = new Person();
                person.Age = 32;
                person.FirstName = $"Matt{i}";
                person.LastName = "Reynolds";
                results.Add(person);
            }

            return results;
        }
    }
}