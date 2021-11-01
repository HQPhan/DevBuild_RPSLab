using System;

namespace RPS_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //I need to recode this section to make the program work.
            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.WriteLine();
            
            RPSApp app = new RPSApp();
            Console.WriteLine(app.Oponent.Name);

            UserPlayer p = new UserPlayer();
            RPSEnum result = p.GetRPS();
            Console.WriteLine($"{p.Name}: {result}");
            Console.WriteLine();

            Rocky r = new Rocky();
            Console.WriteLine($"Rocky: {r.GetRPS()}");
            Console.WriteLine();

            Randa ra = new Randa();
            Console.WriteLine($"Randa: {ra.GetRPS()}");

            

            //RPSApp app = new RPSApp();
            //app.PickPlayer();
        }
    }
}
