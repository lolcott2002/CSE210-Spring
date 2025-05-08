using System;
public class Job
{
    public string JobTitle;
    public string Company;
    public int StartYear;
    public int EndYear;

    public void Display()
    {
        Console.WriteLine($"Job Title: {JobTitle}");
        Console.WriteLine($"Company: {Company}");
        Console.WriteLine($"Start Year: {StartYear}");
        Console.WriteLine($"End Year: {EndYear}");
    }
}