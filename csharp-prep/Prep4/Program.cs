using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
         Console.WriteLine("enter a list of numbers or 0 when finished ");
            int addednumber = int.Parse(Console.ReadLine());
            while (addednumber != 0)
            {
                numbers.Add(addednumber);
                Console.WriteLine("enter a list of numbers or 0 when finished ");
                addednumber = int.Parse(Console.ReadLine());
            }
            int sum = numbers.Sum();
            Console.WriteLine($"The sum of the list is {sum}");
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average of the list is {average}");
            int max = numbers.Max();
            Console.WriteLine($"The largest number in the list is {max}");
    }
}