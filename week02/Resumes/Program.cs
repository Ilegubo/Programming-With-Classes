using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startDate = new DateOnly(2022,01,01);
        job1._endDate = new DateOnly(2024,01,01);
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startDate = new DateOnly(2024,02,01);
        job2._endDate = new DateOnly(2026,02,01);
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Sam Altman";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}