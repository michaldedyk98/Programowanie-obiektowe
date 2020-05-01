using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Student: Person
    {
        private int year;
        private int group;
        private int indexNumber;
        private List<Grade> grades;

        public int Year { get => year; set => year = value; }
        public int Group { get => group; set => group = value; }
        public int IndexNumber { get => indexNumber; set => indexNumber = value; }

        public Student(string name, string surname, DateTime birthDate, int year, int group, int indexNumber): base(name, surname, birthDate)
        {
            this.year = year;
            this.group = group;
            this.indexNumber = indexNumber;
            this.grades = new List<Grade>();
        }

        public Student()
        {
            year = 0;
            group = 0;
            indexNumber = 0;
            grades = new List<Grade>();
        }

        public override string ToString()
        {
            return $"Student year {year}, group {group}, index number {indexNumber}";
        }

        public override void Details()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine(this);
            PrintGrades();
        }

        public void AddGrade(string subjectName, DateTime date, double gradeValue)
        {
            grades.Add(new Grade(subjectName, date, gradeValue));
        }

        public void RemoveGrade(string subjectName, DateTime date, double gradeValue)
        {
            Grade gradeToRemove = null;

            foreach (Grade grade in grades)
            {
                if (grade.SubjectName == subjectName && grade.Date.Equals(date) && grade.GradeValue == gradeValue) {
                    gradeToRemove = grade;
                    break;
                }
            }
            
            if (gradeToRemove != null)
            {
                grades.Remove(gradeToRemove);
            }
        }

        public void RemoveGrades()
        {
            grades.Clear();
        }

        public void RemoveGrade(string subjectName)
        {
            Grade gradeToRemove = null;

            foreach (Grade grade in grades)
            {
                if (grade.SubjectName == subjectName)
                {
                    gradeToRemove = grade;

                    break;
                }
            }
            if (gradeToRemove != null)
                grades.Remove(gradeToRemove);
        }

        public void PrintGrades()
        {
            foreach (Grade grade in grades)
                grade.Details();
        }

        public void PrintGrades(string subjectName)
        {
            foreach (Grade grade in grades)
                if (grade.SubjectName == subjectName)
                    grade.Details();
        }
    }
}
