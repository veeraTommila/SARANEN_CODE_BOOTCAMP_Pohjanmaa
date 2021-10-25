using System;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess The Number!");
            Random random = new();
            int correctAnswer = random.Next(1, 21);
            Console.WriteLine(correctAnswer);

            for (int tryNumber = 0; tryNumber < 3; tryNumber++){
                Console.WriteLine("Enter your number from 1 to 20:");
                int guess = int.Parse(Console.ReadLine());

                if(guess < correctAnswer){
                    Console.WriteLine("The correct number is greater.");
                }
                else if(guess > correctAnswer){
                    Console.WriteLine("The correct number is lesser.");
                }
                else
                {
                    Console.WriteLine("You won!");
                    break;
                }                
            }
            Console.WriteLine("You lost!");
        }
    }
}
