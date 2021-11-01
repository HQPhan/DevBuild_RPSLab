using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Lab
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
        }

        public override RPSEnum GetRPS()
        {
            Random rnd = new Random();
            int randSelect = rnd.Next(3);
            switch (randSelect)
            {
                case 0:
                    return RPSEnum.Rock;
                case 1:
                    return RPSEnum.Paper;
                case 2:
                    return RPSEnum.Scissors;
                default:
                    return GetRPS();
            }

        }
    }
}
