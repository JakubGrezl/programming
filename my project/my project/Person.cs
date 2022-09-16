using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    internal class Person
    {
        private string name;
        private string surname;
        private int age;
        private int id;
        public string Name { 
            get { return name; } 
            set {
                if (value == null)
                    Console.WriteLine("Must enter name!");
                    
                else if (value.Length > 24)
                    Console.WriteLine("Must be shorter than 24!");
                else
                name = value; 
            } }

        public Person(string name, string surname, int age, int id)
        {
            this.surname = surname;
            this.age = age;
            this.id = id;
            Name = name;
        }
    }
}
