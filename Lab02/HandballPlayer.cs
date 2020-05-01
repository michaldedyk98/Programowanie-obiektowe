using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class HandballPlayer: Player
    {
        public HandballPlayer(string name, string surname, DateTime birthDate, string position, string club) : base(name, surname, birthDate, position, club)
        {
        }

        public HandballPlayer() : base() { }

        public override void ScoreGoal()
        {
            base.ScoreGoal();

            Console.WriteLine("Handball player scored a goal!");
        }
    }
}
