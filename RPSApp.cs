using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Lab
{
    class RPSApp
    {
        public UserPlayer Player { get; set; } = new UserPlayer();

        public Player Oponent { get; set; }

        public RPSApp()
        {        
            Player = new UserPlayer();
            Console.Write("Who do you want to play against?\nSelect 'Rocky' or 'Randa': ");
            Oponent = PickPlayer(Console.ReadLine().ToLower().Trim());

        }
        public Player PickPlayer(string pick)
        {
            bool pickPlayer = true;
            while (pickPlayer)
            {                
                switch(pick)
                { 
                    case "rocky":
                        Oponent = new Rocky();
                        pickPlayer = false;
                        break;
                    case "randa":
                        Oponent = new Randa();
                        pickPlayer = false;
                        break;
                    default:
                        pickPlayer = true;
                        continue;
                }                
            }
            return Oponent;
        }

        public Player Play()
        {
            //Not sure how to use 2-D string array to get results.
            //I tried doing it this way, but C# does not like it.
            //I will have to go back to fix this
            if (Player.GetRPS() == Oponent.GetRPS())
            {
                return ResultEnum.Tie;
            }
            else if (Player.GetRPS() == RPSEnum.Rock && Oponent.GetRPS() = RPSEnum.Paper)
            {

            }
            else if (Player == RPSEnum.Rock && Oponent == RPSEnum.Scissors)
            {

            }
            else if (Player == RPSEnum.Paper && Oponent == RPSEnum.Rock)
            {

            }
            else if (Player == RPSEnum.Paper && Oponent == RPSEnum.Scissors)
            {

            }
            else if (Player == RPSEnum.Scissors && Oponent == RPSEnum.Rock)
            {

            }
            else if (Player == RPSEnum.Scissors && Oponent == RPSEnum.Paper)
            {

            }
            else
            {
                Console.WriteLine("Not valid");
                return Play();
            }
        }
    }
}
