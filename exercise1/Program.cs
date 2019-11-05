using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)


        {
            
            int pointpl1 = 0;
            int pointpl2 = 0;

            Console.WriteLine("Welcome to Rock Paper Scissor Game");

            for (int round =1; round <=100; round++)
            {
                string player1 = "ROCK";
                Console.WriteLine("Player 1 choice: " + player1);

                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);


                Console.WriteLine("Player 2 choice: " + choices[n]);
                Console.ReadLine();

                
                if ( choices[n]== "SCISSOR")
                {
                    Console.WriteLine("Player1 wins");
                    pointpl1 += 1;
                }
                else if (choices[n] == "PAPER")
                {
                    Console.WriteLine("Player2 wins");
                    pointpl2 += 1;
                }
                else 
                {
                    Console.WriteLine("Same choices");
                }
                Console.WriteLine("You just finished the " + round + "round of the game");
                Console.WriteLine("----------------------------------------------------");
                Console.ReadLine();
            }
            Console.WriteLine("Player1 wins " + pointpl1 + " times");
            Console.ReadLine();
            Console.WriteLine("Player2 wins " + pointpl2 + " times");
            Console.ReadLine();
            if (pointpl1 > pointpl2)
            {
                Console.WriteLine("The winner is player1");
                Console.ReadLine();
           
            }
            else if(pointpl1< pointpl2)
            {
                Console.WriteLine("The winner is player2");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Both players have scored same points");
                Console.ReadLine();
            }

            Console.WriteLine("Thank you for playing Rock Paper Scissor");
            Console.ReadLine();
        }
    }
}
