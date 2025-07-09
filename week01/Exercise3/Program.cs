using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int input = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != input)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (input > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (input < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed the magic number!");
            }
        }
    }
}