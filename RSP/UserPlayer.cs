using System;
using System.Collections.Generic;
using System.Text;

namespace RSP
{
    class UserPlayer : Player
    {
        public UserPlayer() : base()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
        }

        public override RPSEnum GetRPS()
        {
            Console.WriteLine("Please select rock, paper, or scissor. (R/P/S)");
            string answer = Console.ReadLine();
            RPSEnum hand;

            switch(answer)
            {
                case "rock":
                    return RPSEnum.Rock;
                case "r":
                    return RPSEnum.Rock;
                case "paper":
                    return RPSEnum.Paper;
                case "p":
                    return RPSEnum.Paper;
                case "scissors":
                    return RPSEnum.Scissors;
                case "s":
                    return RPSEnum.Scissors;
                default:
                    Console.WriteLine("I couldn't understand your answer. Try again");
                    return GetRPS();
            }
            return hand;
        }
    }
}
