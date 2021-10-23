using System;
using System.Collections.Generic;
using System.Text;

namespace snake_and_ladder_game
{
    class usercase2
    {
        public int dieRoll()
        {

            Random random = new Random();
            int outcome = random.Next(1, 6);
            Console.WriteLine("outcome of die1 is " + outcome);
            return outcome;
        }
    }
}
    

