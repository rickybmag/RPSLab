using System;
using System.Collections.Generic;
using System.Text;

namespace RSP
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
        }

        public override RPSEnum GetRPS()
        {
            Random rand = new Random();
            int thrw = rand.Next(0, 3);
            RPSEnum hand;
            
            switch (thrw)
            {
                case 0:
                    hand = RPSEnum.Rock;
                    break;
                case 1:
                    hand = RPSEnum.Paper;
                    break;
                case 2:
                    hand = RPSEnum.Scissors;
                    break;
                default:
                    return GetRPS();
            }
            return hand;
        }

    }
}
