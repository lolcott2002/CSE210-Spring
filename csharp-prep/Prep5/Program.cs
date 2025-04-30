using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
        {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        string PromptUserName()
        {
            Console.Write("what will your username be? ");
            string username = Console.ReadLine();
            return username;
        }
        int PromptUserNumber()
        {
            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        int SquareNumber(int number)
        {
            int numbersquared = number * number;
            return numbersquared;
        }
        void DisplayResult(string username, int number, int numbersquared)
        {
            Console.WriteLine($"your username is {username}, your number is {number}, your number squared is {numbersquared}");
        }
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int numbersquared = SquareNumber(number);
        DisplayResult(username, number, numbersquared);
    }
}