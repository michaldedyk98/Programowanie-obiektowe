﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Reptile : Animal
    {
        public bool Venomous { get; set; }

        public Reptile(string species, int legsCount, string typeOfFood, string origin, bool venomous) : base(typeOfFood, legsCount, origin, species)
        {
            Venomous = venomous;
        }

        public override string ToString()
        {
            return base.ToString() + $", is venomous: {(Venomous ? "Yes" : "No")}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(this);
        }
    }
}
