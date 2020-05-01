using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person o = new Person("Adam", "Mis", new DateTime(1990, 12, 29));
            Person o2 = new Student("Michal", "Kot", new DateTime(1990, 12, 29), 2, 1, 12345);
            Person o3 = new Player("Mateusz", "Żbik", new DateTime(1990, 12, 29), "obrońca", "FC Częstochowa");

            o.Details();
            o2.Details();
            o3.Details();

            Student s = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 29), 2, 5, 54321);
            Player p = new Player("Piotr", "Kos", new DateTime(1990, 12, 29), "napastnik", "FC Politechnika");

            s.Details();
            p.Details();

            ((Player)o3).ScoreGoal();
            p.ScoreGoal();
            p.ScoreGoal();

            o3.Details();
            p.Details();

            ((Student)o2).AddGrade("PO", new DateTime(2011, 12, 29), 5.0);
            ((Student)o2).AddGrade("Bazy danych", new DateTime(2011, 12, 29), 4.0);

            o2.Details();

            s.AddGrade("Bazy danych", new DateTime(2011, 12, 29), 5.0);
            s.AddGrade("AWWW", new DateTime(2011, 2, 15), 5.0);
            s.AddGrade("AWWW", new DateTime(2011, 9, 12), 4.5);

            s.PrintGrades();

            s.RemoveGrade("AWWW", new DateTime(2011, 5, 3), 4.5);

            s.PrintGrades();

            s.AddGrade("AWWW", new DateTime(2011, 10, 12), 4.5);
            s.RemoveGrade("AWWW");

            s.PrintGrades();

            s.AddGrade("AWWW", new DateTime(2011, 12, 22), 4.5);
            s.RemoveGrades();

            s.Details();

            FootballPlayer p3 = new FootballPlayer("Jan", "Kowalski", new DateTime(1990, 12, 29), "Atakujacy", "FC 2");
            HandballPlayer p4 = new HandballPlayer("Jan", "Nowakowski", new DateTime(1950, 12, 29), "Atakujacy", "FC 2");

            p3.ScoreGoal();
            p4.ScoreGoal();
            p4.ScoreGoal();

            p3.Details();
            p4.Details();

            Console.ReadKey();
        }
    }
}
