using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Lab
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            Console.Write("What is your name?: ");
            Name = Console.ReadLine();
        }

        //We want our user to select R P or S
        //and if we get anything else, ask for an RPS value again
        public override RPSEnum GetRPS()
        {
            Console.Write("Please select (r)ock (p)aper or (s)cissors: ");
            string input = Console.ReadLine();

            switch (input)
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
                    Console.WriteLine("Invalid input. Try again!");
                    return GetRPS();
                   
            }
        }
    }
}
