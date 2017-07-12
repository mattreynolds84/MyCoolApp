using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolApp
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }
        public int HeightInInches { get; set; }
        public int WeightInPounds { get; set; }
        public string DisplayName
        {
            get { return $"{FirstName} {LastName}: {Age} Is Male:{IsMale}"; }
        }

        public bool IsMale { get; set; }
    }
}
