using System;

namespace snake_and_ladder_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Welcome to snake & ladder game");
            Console.WriteLine("starting position is " +position);


            usercase7 player1 = new usercase7();
            usercase7 player2 = new usercase7();
            player1.Die1();
            player2.Die1();
            player1.Die2();
            player2.Die2();
            player1.Check1();
            Console.WriteLine("Player1's total move " + player1.Check1() + " ");
            player2.Check2();
            Console.WriteLine("Player2's total move " + player2.Check2() + "");

            if (player1.Check1() > player2.Check2())
            {
                Console.WriteLine("Player1 is won by " + (player1.Check1() - player2.Check2()) + " moves");
            }
            else
            {
                Console.WriteLine("Player2 is won by " + (player2.Check2() - player1.Check1()) + " moves");
            }
        }
    }
}

        
    

