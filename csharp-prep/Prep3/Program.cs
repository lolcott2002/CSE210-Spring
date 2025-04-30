using System;

class Program
{
    static void Main(string[] args)
      
     {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.Write("what is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("lower");
            }
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
    }
}