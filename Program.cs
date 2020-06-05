// Made by Jordan Leich on 6/5/2020

using System;
using System.Threading;

namespace Learning_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int random_number;
            Random random_num = new Random();
            random_number = random_num.Next(1, 500);

            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("");
            int tries = 0;

            game(random_number, tries);

            static void game(int random_number, int tries)
            {
                Console.WriteLine("Please guess a number between 1 and 500: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                if (guess < 1)
                {
                    tries += 1;
                    Console.WriteLine("Please only guess a number between 1 and 500!");
                    Console.WriteLine("");
                    game(random_number, tries);
                }

                else if (guess > 500)
                {
                    tries += 1;
                    Console.WriteLine("Please only guess a number between 1 and 500!");
                    Console.WriteLine("");
                    game(random_number, tries);
                }

                else if (guess < random_number)
                {
                    tries += 1;
                    Console.WriteLine("Your guess is too low!");
                    Console.WriteLine("");
                    game(random_number, tries);
                }

                else if (guess > random_number)
                {
                    tries += 1;
                    Console.WriteLine("Your guess is too high!");
                    Console.WriteLine("");
                    game(random_number, tries);
                }

                else if (guess == random_number)
                {
                    Console.WriteLine("You guessed the correct number in " + tries + " tries! ");
                    Console.WriteLine("");
                    Thread.Sleep(3000);
                    Console.WriteLine("Ending program now...");
                    Thread.Sleep(2000);
                }

                else
                {
                    Console.WriteLine("Invalid Input... Ending Program now...");
                    Console.WriteLine("");
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
