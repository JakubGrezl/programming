using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    internal class Application
    {
   
        public Application()
        {

            List<Person> people = new List<Person>();

            for (int i = 0; i < 40; i++)
            {
                Person person = new Person("Karel", "Vojta", 18 + i, i);
                people.Add(person);
                Console.WriteLine("name: " + person.Name);
            }

            
        }
    }
}
