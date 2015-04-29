using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string birthday;

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public string Birthday{ get { return birthday; } }

        public DateTime EventDate { get; set; }
        public bool Present { get; set; }
        public bool  Attend { get; set; }

        public DateTime CampDate { get; set; }
        public int NoPersons { get; set; }
        public bool Allow { get; set; }
        public Person()
        {

        }
    }
}
