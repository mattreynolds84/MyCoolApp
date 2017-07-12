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
    }
}
