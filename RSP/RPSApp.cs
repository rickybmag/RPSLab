using System;
using System.Collections.Generic;
using System.Text;

namespace RSP
{
    class RPSApp
    {
        public UserPlayer Player { get; set; } = new UserPlayer();
        public int Draws { get; set; } = 0;

        public Player Opponent { get; set; }

        public RPSApp()
        {
            //Later on, once we have Randa, replace this line with code that let's the player choose their opponent
           while (true)
           {
                Console.WriteLine("Choose your opponent: Rocky or Randa");
                string input = Console.ReadLine();

                if(input == "Rocky")
                {
                    Opponent = new Rocky();
                    break;
                }
                else if (input == "Randa")
                {
                    Opponent = new Randa();
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose between Rocky or Randa for your opponent");
                    continue;
                }                
           }
        }

        public Player Play()
        {
            RPSEnum player = Player.GetRPS();
            RPSEnum opponent = Opponent.GetRPS();
            Player winner = null;
            if (player == opponent)
            {
                Console.WriteLine("This match is a draw!");
                Draws++;
            }
            else if (player == RPSEnum.Rock)
            {
                if (opponent == RPSEnum.Paper)
                {
                    Console.WriteLine($"{Player.Name} loses!");
                    Console.WriteLine($"{Opponent.Name} wins!");                    
                }
                else
                {
                    Console.WriteLine($"{Opponent.Name} loses!");
                    Console.WriteLine($"{Player.Name} wins!");
                }
            }
            else if (player == RPSEnum.Paper)
            {
                if (opponent == RPSEnum.Scissors)
                {
                    Console.WriteLine($"{Player.Name} loses!");
                    Console.WriteLine($"{Opponent.Name} wins!");
                }
                else
                {
                    Console.WriteLine($"{Opponent.Name} loses!");
                    Console.WriteLine($"{Player.Name} wins!");
                }
            }
            else if(player == RPSEnum.Scissors)
            {
                if (opponent == RPSEnum.Rock)
                {
                    Console.WriteLine($"{Player.Name} loses!");
                    Console.WriteLine($"{Opponent.Name} wins!");
                }
                else
                {
                    Console.WriteLine($"{Opponent.Name} loses!");
                    Console.WriteLine($"{Player.Name} wins!");
                }
            }
            else
            {
                Console.WriteLine("Please enter rock, paper, or scissors");
                return Play();
            }
            return winner;
        }
    }
}
