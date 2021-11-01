using System;
using System.Collections.Generic;
using System.Text;

namespace RSP
{
    enum RPSEnum    {Rock, Paper, Scissors}

    abstract class Player
    {
        public string Name { get; set; }
        public RPSEnum RPS { get; set; }

        public Player()
        {
            this.Name = Name;
        }

        public abstract RPSEnum GetRPS();

    }
}
