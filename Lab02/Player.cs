using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Player: Person
    {
        private string position;
        private string club;
        private int scoredGoals = 0;

        public string Position { get => position; set => position = value; }
        public string Club { get => club; set => club = value; }
        public int ScoredGoals { get => scoredGoals; set => scoredGoals = value; }

        public Player(string name, string surname, DateTime birthDate, string position, string club) : base(name, surname, birthDate)
        {
            Position = position;
            Club = club;
        }

        public Player() : base()
        {
            Position = "None";
            Club = "None";
        }

        public override string ToString()
        {
            return $"Player position {position}, club {club}, scored goals {scoredGoals}";
        }

        public override void Details()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine(this);
        }

        public virtual void ScoreGoal()
        {
            scoredGoals++;
        }
    }
}
