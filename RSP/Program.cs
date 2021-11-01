using System;

namespace RSP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            UserPlayer p = new UserPlayer();
            RPSApp rps = new RPSApp();

            while (keepPlaying)
            {
                RPSEnum result = p.GetRPS();

                //Console.WriteLine(result);

                rps.Play();

                keepPlaying = Continue();
            }
        }

        public static bool Continue()
        {
            Console.Write("Would you like to play again?(y/n) ");
            string response = Console.ReadLine();
            response = response.Trim().ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                Console.WriteLine("See you soon!");
                return false;
            }
            else
            {
                Console.WriteLine("Please input a valid entry");
                return Continue();
            }
        }
    }
}
