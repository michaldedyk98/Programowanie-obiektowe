using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Librarian : Person
    {
        private DateTime hireDate;
        private double salary;

        public DateTime HireDate { get => hireDate; set => hireDate = value; }
        public double Salary { get => salary; set => salary = value; }

        public Librarian(string name, string surname, DateTime hireDate, double salary) : base (name, surname)
        {
            this.hireDate = hireDate;
            this.salary = salary;
        }

        public Librarian() : base()
        {
            hireDate = new DateTime();
            salary = 0.0;
        }

        public override string ToString()
        {
            return base.ToString() + $" hire date {hireDate}, salary {salary}";
        }
    }
}
