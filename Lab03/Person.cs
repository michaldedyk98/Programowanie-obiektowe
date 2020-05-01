using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Person
    {
        private string name;
        private string surname;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Person()
        {
            name = "None";
            surname = "None";
        }

        public override string ToString()
        {
            return $"Person: {name} {surname}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
