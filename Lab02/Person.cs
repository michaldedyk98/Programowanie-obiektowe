using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;
        protected string Name { get => name; set => name = value; }
        protected string Surname { get => surname; set => surname = value; }
        protected DateTime BirthDate { get => birthDate; set => birthDate = value; }

        public Person(string name, string surname, DateTime birthDate)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
        }

        public Person()
        {
            name = "None";
            surname = "None";
            birthDate = new DateTime(0);
        }

        public override string ToString()
        {
            return $"Person {name} {surname} was born in {birthDate}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}
