using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Lab
{
    abstract class Player
    {
        public string Name { get; set; }
        public ResultEnum Result { get; set; }
        public RPSEnum RPS { get; set; }
        public abstract RPSEnum GetRPS();
    }
}
