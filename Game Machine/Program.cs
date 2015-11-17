using System;

namespace Game_Machine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Game Machine");
            Console.WriteLine("Do you want to play? Type 'y' to play");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                GameMachine();
            }
            else
            {
                Console.WriteLine("Good bye!");
            }
            Console.ReadKey();
        }

        public static void GameMachine()
        {
            Console.WriteLine("Try to guess a number.");
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int count = 0;
            int input = 0;
            int userInput = 0;
            int lowBorder = 0;
            int highBorder = 100;
     
            while (userInput != numberToGuess)
            {
                Console.WriteLine("Guess a number from " + lowBorder + " to " + highBorder);
                try
                {
                    string yourGuess = Console.ReadLine();
                    input = int.Parse(yourGuess);
                }

                catch (FormatException e)
                {
                    Console.WriteLine("It's not a number. Please re-type.");
                    continue;
                }
                try
                {
                    if (input < lowBorder | input > highBorder)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Your number is out of range. Please re-type.");
                    continue;
                }
                if (input < numberToGuess)
                    {
                        Console.WriteLine("Your guess is to low. Try higher.");
                        count++;
                        lowBorder = input;
                    }

                else if (input > numberToGuess)
                {
                    Console.WriteLine("Your guess is to high. Try lower.");
                    count++;
                    highBorder = input;
                }
                else if (input == numberToGuess)
                {
                    Console.WriteLine("Well done! It takes " + count + " guesses.");
                    break;
                }
            }
            }
        }
    }
