using System;
using System.Collections.Generic;
using System.Text;

namespace RSP
{
    class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }
        public override RPSEnum GetRPS()
        {
            return RPSEnum.Rock;
        }
    }
}
