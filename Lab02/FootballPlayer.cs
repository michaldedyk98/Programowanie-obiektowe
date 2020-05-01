using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class FootballPlayer: Player
    {
        public FootballPlayer(string name, string surname, DateTime birthDate, string position, string club) : base(name, surname, birthDate, position, club)
        {
        }
        public FootballPlayer() : base() { }


        public override void ScoreGoal()
        {
            base.ScoreGoal();

            Console.WriteLine("Football player scored a goal!");
        }
    }
}
