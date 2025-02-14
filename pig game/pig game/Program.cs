using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pig_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totalScore = 0;
            int turn = 1;
            const int WINNING_SCORE = 20;

            Console.WriteLine("Let's Play PIG!\n");

            while (totalScore < WINNING_SCORE)
            {
                int turnScore = 0;
                Console.WriteLine($"TURN {turn}");

                while (true)
                {
                    Console.Write("Roll or hold? (r/h): ");
                    char choice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (choice == 'r')
                    {
                        int roll = random.Next(1, 7);
                        Console.WriteLine($"Die: {roll}");

                        if (roll == 1)
                        {
                            Console.WriteLine("Turn over. No score.\n");
                            break;
                        }

                        turnScore += roll;
                    }

                    if (choice == 'h')
                    {
                        totalScore += turnScore;
                        Console.WriteLine($"Score for turn: {turnScore}, Total score: {totalScore}\n");
                        break;
                    }
                }

                turn++;
            }

            Console.WriteLine($"You finished in {turn - 1} turns! Game over!");
        }
    }
}
