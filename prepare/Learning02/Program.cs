using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1.JobTitle = "Electrical Engineer";
        job1.Company = "Madison Electrical Engineering";
        job1.StartYear = 2022;
        job1.EndYear = 2023;

        Job job2= new Job();
        job2.JobTitle = "Software Engineer";
        job2.Company = "Microsoft";
        job2.StartYear = 2023;
        job2.EndYear = 2025;

        Resume myresume = new Resume();
        myresume._name = "Logan Olcott";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);
        myresume.Display();
    }
}