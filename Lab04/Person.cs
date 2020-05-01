using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;

        public int Id { get; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        static int _id = 0;

        public Person(string name, string surname, int age)
        {
            Id = _id++;

            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Person()
        {
            Id = _id++;

            name = "None";
            surname = "None";
            age = 0;
        }

        public override string ToString()
        {
            return $"Person: {name} {surname} age: {age}, ID: {Id}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
