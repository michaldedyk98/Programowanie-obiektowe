using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Grade
    {
        private string subjectName;
        private DateTime date;
        private double gradeValue;

        public string SubjectName { get => subjectName; set => subjectName = value; }
        public DateTime Date { get => date; set => date = value; }
        public double GradeValue { get => gradeValue; set => gradeValue =  value; }

        public Grade(string subjectName, DateTime date, double value)
        {
            this.subjectName = subjectName;
            this.date = date;
            this.GradeValue = value;
        }

        public Grade()
        {
            subjectName = "None";
            date = new DateTime(0);
            gradeValue = 0;
        }


        public override string ToString()
        {
            return $"[{date}] Subject name {subjectName}, grade: {gradeValue}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
